using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Branch
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
