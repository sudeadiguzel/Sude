using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,ErrorMessage ="Max 60 char lenght For Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Do not leave blank")]
        [Range(1,1000000)]
        public double? Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Category { get; set; }

        public bool IsApproved { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
