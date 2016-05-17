using System.Collections.Generic;

namespace SmarTaxiWeb.Models
{
    public class BoardDirectors
    {
        public long Id { get; set; }
        public ICollection<PersonInformation> Directors { get; set; }
    }
}