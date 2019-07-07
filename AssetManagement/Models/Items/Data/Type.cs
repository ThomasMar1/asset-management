using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models.Items.Data
{
    public class Type
    {
        public string TypeId { get; set; }

        [Required]
        public string TypeName { get; set; }
    }
}
