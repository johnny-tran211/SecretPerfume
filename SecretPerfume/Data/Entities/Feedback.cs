using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Feedback
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [Required]
        public string Fullname { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }
    }
}
