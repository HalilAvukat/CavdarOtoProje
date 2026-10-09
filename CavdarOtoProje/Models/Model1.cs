using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CavdarOtoProje.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CavdarOtoDBModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
