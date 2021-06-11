using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class ProductImage
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Image { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Thumbnail { get; set; }

        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Product_Id { get; set; }
        public Product Product { get; set;}
    }
}
