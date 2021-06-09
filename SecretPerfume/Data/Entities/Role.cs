using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Role
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required]
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
