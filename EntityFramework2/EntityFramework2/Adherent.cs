namespace EntityFramework2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adherent")]
    public partial class Adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adherent()
        {
            Emprunts = new HashSet<Emprunt>();
        }

        [Key]
        [StringLength(4)]
        public string CodeA { get; set; }

        [StringLength(100)]
        public string NomA { get; set; }

        [StringLength(200)]
        public string Adresse { get; set; }

        public DateTime? DateInscription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprunt> Emprunts { get; set; }
    }
}
