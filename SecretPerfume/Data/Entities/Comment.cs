using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data.Entities
{
    public class Comment
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        public string Content { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string ImageUrl { get; set; }

        // Foreign Key
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string User_Id { get; set; }
        public User User { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Product_Id { get; set; }
        public Product Product { get; set; }
    }
}
