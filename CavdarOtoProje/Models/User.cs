using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CavdarOtoProje.Models
{
    public class User
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Boş Bırakılamaz")]
        [StringLength(maximumLength: 75, ErrorMessage = "En Fazla 75 Karakter")]
        public string name { get; set; }

        [StringLength(maximumLength: 75, ErrorMessage = "En Fazla 75 Karakter")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Mail Adresi Boş Bırakılamaz")]
        [StringLength(maximumLength: 75, MinimumLength = 3, ErrorMessage = "Mail Adresi 3-75 karakter arası olmalıdır")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Mail adresi hatalı")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [StringLength(maximumLength: 16, MinimumLength = 8, ErrorMessage = "Şifre 8-16 karakter arası olmalıdır")]
        public string password { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual List<UserCart> UserCarts { get; set; }


    }
}