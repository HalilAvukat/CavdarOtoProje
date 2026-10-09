using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CavdarOtoProje.Models
{
    public class Product
    {

        public int ID { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }


        [Required(ErrorMessage = "Isim Boş Bırakılamaz")]
        [StringLength(maximumLength: 75)]
        public string Name { get; set; }


        [DataType(DataType.MultilineText)]
        [StringLength(maximumLength: 500, ErrorMessage = "En fazla 500 karakter olabilir")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat Boş Bırakılamaz")]
        public decimal Price { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }

        public bool IsDeleted { get; set; } = true;


        public virtual List<UserCart> UserCarts { get; set; }
        public virtual ICollection<Comment> comments { get; set; }

    }
}