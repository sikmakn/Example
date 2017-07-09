using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class UserViewModels
    {
        [Required]
        [Display(Name = "name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "password")]
        public string Password { get; set; }
        public string Id { get; set; }
    }
}