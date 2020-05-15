using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Classematiere
    {
        [Key]
        public int id { get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Nom Classe") ]
        public string nomClasse{ get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Filiére") ]
        public string filiere{ get; set;}

     
       


    }
}