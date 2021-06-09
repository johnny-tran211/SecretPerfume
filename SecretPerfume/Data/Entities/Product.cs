using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Product
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        [Required]
        public int Stock { get; set; }


        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Branch_Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Discount_Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public virtual List<ProductImage> ProductImages { get; set; }
        public virtual List<Rating> Ratings { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
