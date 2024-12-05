namespace EntityFramework2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBiblio : DbContext
    {
        public ModelBiblio()
            : base("name=ModelBiblio")
        {
        }

        public virtual DbSet<Adherent> Adherents { get; set; }
        public virtual DbSet<Emprunt> Emprunts { get; set; }
        public virtual DbSet<Livre> Livres { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adherent>()
                .Property(e => e.CodeA)
                .IsUnicode(false);

            modelBuilder.Entity<Adherent>()
                .Property(e => e.NomA)
                .IsUnicode(false);

            modelBuilder.Entity<Adherent>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Adherent>()
                .HasMany(e => e.Emprunts)
                .WithRequired(e => e.Adherent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Emprunt>()
                .Property(e => e.CodeA)
                .IsUnicode(false);

            modelBuilder.Entity<Emprunt>()
                .Property(e => e.CodeL)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .Property(e => e.CodeL)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .Property(e => e.Titre)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .Property(e => e.Auteur)
                .IsUnicode(false);

            modelBuilder.Entity<Livre>()
                .HasMany(e => e.Emprunts)
                .WithRequired(e => e.Livre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.IntituleTh)
                .IsUnicode(false);
        }
    }
}
