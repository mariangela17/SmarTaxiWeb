using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class PhoneInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "AreaCode")]
        public string AreaCode { get; set; }
        [Required]
        [Phone]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}