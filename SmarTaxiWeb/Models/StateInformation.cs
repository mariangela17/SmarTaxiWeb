using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class StateInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "StateName")]
        public string StateName { get; set; }
    }
}