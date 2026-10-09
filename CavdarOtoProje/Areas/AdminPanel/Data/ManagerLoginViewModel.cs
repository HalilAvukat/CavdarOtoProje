using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CavdarOtoProje.Areas.AdminPanel.Data
{
    public class ManagerLoginViewModel
    {
        //Bu Sınıfın amacı viewdan sadece mail ve şifre bilgisini almak
        //Tüm manager bilgilerine ihtiyacımız yok
        [Required(ErrorMessage = "Mail Zorunludur")]
        [StringLength(maximumLength: 75, MinimumLength = 3, ErrorMessage = "Mail 3-75 karakter arası olmalıdır")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Mail adresi hatalı")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Zorunuludur")]
        [StringLength(maximumLength: 16, MinimumLength = 8, ErrorMessage = "Şifre 8-16 karakter arası olmalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}