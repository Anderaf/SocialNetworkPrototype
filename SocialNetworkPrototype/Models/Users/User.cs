using Microsoft.AspNetCore.Identity;
using System;

namespace SocialNetworkPrototype.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }

        public string Status { get; set; }

        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public User()
        {
            Image = "https://i.ibb.co/9bCtHR6/default-profile-icon-24.jpg";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }
    }
}
