namespace EntityFramework2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emprunt")]
    public partial class Emprunt
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string CodeA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodeL { get; set; }

        public DateTime? dateEmprunt { get; set; }

        public DateTime? dateRetour { get; set; }

        public virtual Adherent Adherent { get; set; }

        public virtual Livre Livre { get; set; }
    }
}
