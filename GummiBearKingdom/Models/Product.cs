using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public string OriginCountry { get; set; }
        public string Image { get; set; }
    }
}
