using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment_2.Models
{
    public partial class UserManagement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your Username.")]
        public string Username { get; set; }
        public string Displayname { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your Email.")]
        public string Email { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime? RegisteredDate { get; set; }
    }
}
