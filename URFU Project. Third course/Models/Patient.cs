using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace URFU_Project._Third_course.Models
{
    public class Patient
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public Gender Sex { get; set; }
        [Required]
        public long MedicalPolicy { get; set; }
        [Required]
        public string? BirthDate { get; set; }
        public string? Address { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return $"{Surname} {Name} {MiddleName}"; }
        }
        
    }
}
