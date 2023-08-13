using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thiaqah.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name Is Required!.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Is Required!.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email Is Required!.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3]\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter a Valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Birth Date Is Required!.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy.MM.dd}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Password Is Required!.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConformPassword { get; set; }
    }
}
