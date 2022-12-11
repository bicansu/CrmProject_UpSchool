using Crm.UpSchool.DataAccessLayer.Concrete;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using CrmUpSchool.UILayer.Areas.Employee.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IMessageService messageService, UserManager<AppUser> userManager = null)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SendMessage()
        {           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message m)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.SenderEmail = user.Email;
            m.SerderName = user.Name + " " + user.Surname;

            using (var context = new Context())
            {
                m.ReceiverName = context.Users.Where(x => x.Email == m.ReceiverEmail).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
            _messageService.TInsert(m);
            return RedirectToAction("SendMessage");
           
        }

        [HttpGet]
        public async Task<IActionResult> SendEmail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();


            //Gönderen mail adresi
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "melisasmbl.86@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //alıcı mail adresi
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",p.ReceiverEmail);
            mimeMessage.To.Add(mailboxAddressTo);

            //Mesajın içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = p.EmailContent;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            //Mesajın konusu
            mimeMessage.Subject = p.EmailSubject;
            
            //Mesajı gönderilmesi için 
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com",587, false);
            client.Authenticate("melisasmbl.86@gmail.com", "eyyitgugaqqhfqck");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
