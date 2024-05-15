using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        [Compare("Password",ErrorMessage ="Şifreler Eşleştirilemedi.")]
        public string ConfirmedPassword { get; set; }
    }
}
