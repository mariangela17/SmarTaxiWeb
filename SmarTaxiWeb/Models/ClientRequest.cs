using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class ClientRequest
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Person")]
        public PersonInformation Person { get; set; }
    }
}