using System.ComponentModel.DataAnnotations;

namespace Omdbapi.Cms.Models
{
    public class LoginViewModel
    {
        [Required] 
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
