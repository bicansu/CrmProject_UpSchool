using AutoMapper;
using CrmUpSchool.DTOLayer.CustomerDTOs;
using CrmUpSchool.DTOLayer.DTOs.ContactDTOs;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ContactAddDTO, Contact>();
            CreateMap<Contact, ContactAddDTO>();

            CreateMap<ContactListDTO, Contact>();
            CreateMap<Contact, ContactListDTO>();

            CreateMap<ContactUpdateDTO, Contact>();
            CreateMap<Contact, ContactUpdateDTO>();

            CreateMap<CustomerAddDTO, Customer>();
            CreateMap<Customer, CustomerAddDTO>();

        }
    }
}
