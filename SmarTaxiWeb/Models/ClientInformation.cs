using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class ClientInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Person")]
        public PersonInformation Person { get; set; }
    }
}