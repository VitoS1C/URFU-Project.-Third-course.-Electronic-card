using System.ComponentModel.DataAnnotations;

namespace URFU_Project._Third_course.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
