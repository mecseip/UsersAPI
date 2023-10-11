using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersAPI.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
