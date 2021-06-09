using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static SecretPerfume.Enums.CommonEnums;

namespace SecretPerfume.Data.Entities
{
    public class Order
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        public int AmountProduct { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string ShippingAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string OrderAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string OrderAddress2 { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required]
        public string OrderPhone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string OrderEmail { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public OrderStatus OrderStatus { get; set; }
        [Required]
        public double Price { get; set; }

        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Customer_Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Discount_Id { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
