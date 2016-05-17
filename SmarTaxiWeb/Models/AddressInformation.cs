using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class AddressInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }
    }
}