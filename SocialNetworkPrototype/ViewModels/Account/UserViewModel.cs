using SocialNetworkPrototype.Models.Users;
using System.Collections.Generic;

namespace SocialNetworkPrototype.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }
        public List<User> Friends { get; set; }
    }
}
