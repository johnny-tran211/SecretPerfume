using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class OrderDetail
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string SKU { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Order_Id { get; set; }
        public Order Order { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Product_Id { get; set; }
        public Product Product { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Discount_Id { get; set; }
        public Discount Discount { get; set; }
    }
}
