using System;
using System.ComponentModel.DataAnnotations;

namespace URFU_Project._Third_course.Models
{
    internal class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string? MiddleName { get; set; }
        [Required,]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
