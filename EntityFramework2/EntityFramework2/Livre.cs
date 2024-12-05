namespace EntityFramework2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Livre")]
    public partial class Livre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livre()
        {
            Emprunts = new HashSet<Emprunt>();
        }

        [Key]
        [StringLength(10)]
        public string CodeL { get; set; }

        [Required]
        [StringLength(100)]
        public string Titre { get; set; }

        [StringLength(100)]
        public string Auteur { get; set; }

        public int? NbExemplaires { get; set; }

        public int? CodeTh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprunt> Emprunts { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
