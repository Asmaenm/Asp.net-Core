using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project.Models
{
    public class Professeur
    {
        [Key]
        [DisplayName ("Id professeur") ]
        public int id{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("Nom") ]
        public string nomProf{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("Prénom") ]
        public string prenomProf{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("Téléphone") ]
        public string tel{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("E-mail") ]
        public string emailProf{ get; set;}
    }
}