using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CavdarOtoProje.Models
{
    public class Comment
    {

        public int ID { get; set; }

        public int category_id { get; set; }

        public int user_id { get; set; }


        [ForeignKey("user_id")]
        public virtual User users { get; set; }

        [StringLength(maximumLength: 500)]
        public string comment { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime createdat { get; set; }

    }
}