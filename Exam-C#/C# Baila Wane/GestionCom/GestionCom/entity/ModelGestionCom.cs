namespace GestionCom.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGestionCom : DbContext
    {
        public ModelGestionCom()
            : base("name=ModelGestionCom")
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.Commande)
                .WithRequired(e => e.Article)
                .HasForeignKey(e => e.Id_Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Telephone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Commande)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Id_Client)
                .WillCascadeOnDelete(false);
        }
    }
}
