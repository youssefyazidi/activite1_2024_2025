using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework1
{
    //Classe entite
    [Table("t_atelier")]
    public class Atelier
    {
        //Champs de données
        [Key]
        [Column(name:"AteNum")]
        public int AtelierNum { get; set; }

        [MaxLength(60)]
        [Required]
        public string Specialite { get; set; }
        
        //Champs relation
        public ICollection<Cuisinier> Cuisiniers { get; set; }
 
    }
}