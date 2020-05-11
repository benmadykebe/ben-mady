namespace Monprojet.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelArticle : DbContext
    {
        public ModelArticle()
            : base("name=ModelArticle")
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.Categorie)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.FullName)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Pwd)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Profil)
                .IsFixedLength();
        }
    }
}
