using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmarTaxiWeb.Models
{
    public class Driver
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Person")]
        public PersonInformation Person { get; set; }

    }
}