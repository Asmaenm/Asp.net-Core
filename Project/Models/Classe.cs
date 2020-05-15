using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Classe
    {
        [Key]
        public int id { get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Nom Classe") ]
        public string nomClasse{ get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Filiére") ]
        public string filiere{ get; set;}

     
       /*[Required]
        public int idmatiere{get; set;}

        [ForeignKey("id")]
        public Matiere matiere{get; set;}
   
        [Required]
        public int idmatiereprof{get; set;}

        [ForeignKey("id")]
        public MatiereProf matiereProf{get; set;} */


    }
}