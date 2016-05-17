using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class ContactInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public PhoneInformation Phone { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}