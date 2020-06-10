using System.ComponentModel.DataAnnotations;

namespace SpeakerClient
{
    public class Speaker
    {
        public string SpeakerId {get; set;}
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string AreaSpecification {get; set;}
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string City {get; set;}
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string Province {get; set;}
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$")]
        public string Employer {get; set;}
    }
}