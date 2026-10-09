using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CavdarOtoProje.Models
{
    public partial class CavdarOtoDBModel : DbContext
    {
        public CavdarOtoDBModel()
            : base("name=CavdarOtoDBModel1")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<ManagerType> ManagerTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
