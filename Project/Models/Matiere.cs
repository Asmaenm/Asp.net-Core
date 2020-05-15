using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project.Models
{
    public class Matiere
    {
        [Key]
        public int Id{get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Matiére") ]
        
        public string Nom{get; set;}


    }
}