using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static SecretPerfume.Enums.CommonEnums;

namespace SecretPerfume.Data.Entities
{
    public class User
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        public string PassHash { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Required]
        public string Firstname { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Required]
        public string Lastname { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public Gender Gender { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Address { get; set; }

        // Foreign Key
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Role_Id { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Rating> Ratings { get; set; }
    }
}
