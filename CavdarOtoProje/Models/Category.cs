using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CavdarOtoProje.Models
{
    public class Category
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Boş Bırakılamaz")]
        [StringLength(maximumLength: 75, ErrorMessage = "En Fazla 75 Karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama Boş Bırakılamaz")]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}