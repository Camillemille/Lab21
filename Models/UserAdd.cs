using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class UserAdd
    {
        public UserAdd()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Password = "";

        }
        [Required] // attributes
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string LastName { set; get; }

        [Required] // attributes
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string Email { set; get; }

        [Required] // attributes
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string PhoneNumber { set; get; }

        [Required] // attributes
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string Password { set; get; }

        public UserAdd(string firstname, string lastname, string email, string phonenumber, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            Password = password;

        }


    }
}