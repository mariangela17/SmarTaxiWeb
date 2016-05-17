using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class TaxiLine
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Rif")]
        public string Rif { get; set; }
        [Required]
        [Display(Name = "Nit")]
        public string  Nit { get; set; }
        [Required]
        [Display(Name = "Direction")]
        public string Direction { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public ContactInformation Contact { get; set; }
        [Required]
        [Display(Name = "Address")]
        public AddressInformation Address { get; set; }
        [Required]
        [Display(Name = "User")]
        public UserInformation User { get; set; }
        public ICollection<Driver> Drivers { get; set; }
        public ICollection<ClientInformation> Clients { get; set; }
        public ICollection<ClientRequest> ClientRequests { get; set; }

    }
}