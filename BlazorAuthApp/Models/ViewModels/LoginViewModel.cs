using System.ComponentModel.DataAnnotations;

namespace BlazorAuthApp.Models.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "please enter username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "please enter password"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
