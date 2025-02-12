﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Discount
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        [Required]
        public DateTime ExpiredAt { get; set; }

        [Required]
        public int Amount { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string DiscountForm { get; set; }

        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Discount_Type_Id { get; set; }
        public DiscountType DiscountType { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
