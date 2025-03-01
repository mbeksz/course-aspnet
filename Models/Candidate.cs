using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Please enter your email address")]
        public String? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter your first name")]

        public String? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter your last name")]
        public String? LastName { get; set; } = string.Empty;

        public String FullName => $"{FirstName} {LastName?.ToUpper()}";

         public int? Age { get; set; }
        [Required(ErrorMessage = "Please select a course")]
        public String? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }


    }
}