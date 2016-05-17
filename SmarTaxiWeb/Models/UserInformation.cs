using System.ComponentModel.DataAnnotations;

namespace SmarTaxiWeb.Models
{
    public class UserInformation
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}