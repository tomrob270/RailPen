using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RailPen.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Pension Reference Number")]
        public string PensionReferenceNumber { get; set; }

        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public enum GenderEnum
        {
            Male,
            Female
        }

        [Required]
        public GenderEnum Gender { get; set; }

        [Required]
        public int TargetRetirementAge { get; set; }
        
        public DateTime DateOfRetirement 
        { 
            get
            {
                return DateOfBirth.AddYears(TargetRetirementAge);
            }
            set {}
        }
    }
}
