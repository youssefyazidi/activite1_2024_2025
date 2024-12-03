using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1
{
    class CuisiniersContext : DbContext
    {
        public CuisiniersContext(string conString):
            base(conString)
        {

        }

        //definir les entités
        public IDbSet<Cuisinier> Cuisiniers { get; set; }
        public IDbSet<Atelier> Ateliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("foods");
            modelBuilder.Entity<Cuisinier>().ToTable("t_cuisinier");
        }
    }
}
