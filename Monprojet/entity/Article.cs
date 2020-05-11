namespace Monprojet.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        public int Id { get; set; }

        public int Reference { get; set; }

        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }

        public int Stock { get; set; }

        public int Prix { get; set; }

        [Required]
        [StringLength(10)]
        public string Categorie { get; set; }
    }
}
