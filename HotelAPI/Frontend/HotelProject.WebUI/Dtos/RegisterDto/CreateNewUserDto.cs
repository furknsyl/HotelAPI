using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {

        [Required(ErrorMessage ="Ad alanı boş bırakılamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alanı boş bırakılamaz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
        public int WorkLocationID { get; set; }

    }
}
