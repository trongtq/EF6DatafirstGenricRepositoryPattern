using EF6DatafirstGenricRepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF6DatafirstGenricRepositoryPattern.DB
{
    public class SchoolContextModel: DbContext
    {
        public SchoolContextModel() : base("SchoolDBConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Studient> Studient { get; set; }
        
    }
}
