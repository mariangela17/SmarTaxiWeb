using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class PersonInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Dni")]
        public string Dni { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public ContactInformation Contact { get; set; }
    }
}