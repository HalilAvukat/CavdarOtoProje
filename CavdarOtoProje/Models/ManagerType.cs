using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CavdarOtoProje.Models
{
    public class ManagerType
    {

        public int ID { get; set; }
        [StringLength(maximumLength: 75)]
        public string name { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }

    }
}