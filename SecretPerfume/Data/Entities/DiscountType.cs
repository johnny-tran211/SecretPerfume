using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class DiscountType
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Discount_Form { get; set; }

        public virtual Discount Discount { get; set; }
    }
}
