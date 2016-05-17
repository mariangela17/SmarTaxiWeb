using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmarTaxiWeb.Models
{
    public class Camera
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
        public string Nit { get; set; }
        [Required]
        [Display(Name = "State")]
        public StateInformation State { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public ContactInformation Contact { get; set; }
        [Required]
        [Display(Name = "Directors")]
        public BoardDirectors Directors { get; set; }
        [Required]
        [Display(Name = "User")]
        public UserInformation User { get; set; }
        public ICollection<TaxiLine> TaxiLines { get; set; }
    }
}