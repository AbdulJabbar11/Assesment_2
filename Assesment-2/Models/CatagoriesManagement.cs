using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment_2.Models
{
    public partial class CatagoriesManagement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your Name.")]
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Status { get; set; }
    }
}
