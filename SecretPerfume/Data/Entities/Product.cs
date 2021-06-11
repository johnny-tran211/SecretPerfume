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
        public Branch Branch { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Discount_Id { get; set; }
        public Discount Discount { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Status_Id { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
