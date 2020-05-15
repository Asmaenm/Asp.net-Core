using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project.Models
{
    public class Seance
    {
        [Key]
        public int Id{get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Séance") ]
        public string nomSeance{get; set;}

        
       
    }
}