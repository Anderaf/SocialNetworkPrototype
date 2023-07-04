using AutoMapper;
using SocialNetworkPrototype.Models.Users;
using SocialNetworkPrototype.ViewModels.Account;

namespace SocialNetworkPrototype
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.EmailReg))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.FirstName));
        }
    }
}
