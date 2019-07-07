using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models.Items.Data
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "First name can not exceed 50 charatcers")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Type Type { get; set; }
        public string Url { get; set; }
        [Required]
        public decimal Cost { get; set; }



    }
}
