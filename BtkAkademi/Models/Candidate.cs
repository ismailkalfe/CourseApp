using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is reuired.")]
        public String? Email { get; set;} = String.Empty;
        [Required(ErrorMessage ="FirstName is reuired.")]
        public String? FirstName { get; set;} = String.Empty;
        [Required(ErrorMessage ="LastName is reuired.")]
        public String? LastName { get; set;} = String.Empty;
        
        
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set;} = String.Empty;
        
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}