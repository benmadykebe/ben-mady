namespace GestionCom.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public double QteCommander { get; set; }

        public double Montant { get; set; }

        public int Id_Client { get; set; }

        public int Id_Article { get; set; }

        public virtual Article Article { get; set; }

        public virtual Client Client { get; set; }
    }
}
