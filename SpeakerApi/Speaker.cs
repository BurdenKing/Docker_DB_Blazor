using System.ComponentModel.DataAnnotations;

namespace SpeakerApi
{
    public class Speaker
    {
        public string SpeakerId {get; set;}
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string AreaSpecification {get; set;}
        [Required]
        public string City {get; set;}
        [Required]
        public string Province {get; set;}
        [Required]
        public string Employer {get; set;}
    }
}