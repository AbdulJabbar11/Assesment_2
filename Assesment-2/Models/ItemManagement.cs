using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment_2.Models
{
    public partial class ItemManagement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your CatagoryId.")]
        public int? CatagoryId { get; set; }
        [Required(ErrorMessage = "Please enter your Name.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Costprice { get; set; }
        public string Saleprice { get; set; }
        public string Mainlmage { get; set; }
        public string Itemcode { get; set; }
        public string Maincolor { get; set; }
        public string Status { get; set; }
    }
}
