using System.ComponentModel.DataAnnotations;

namespace DeepJsGrid.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string? PhoneNumber { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
    }
}
