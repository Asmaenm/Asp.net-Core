using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Etudiant 
    {
        [Key]
        [DisplayName ("Id Etudiant") ]
        public int id{ get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Nom") ]
        public string nomEt{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("Prénom") ]
        public string prenomEt{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("Téléphone") ]
        public string tel{ get; set;}

        [Required(ErrorMessage= "Ce champ est obligatoire!")]
        [DisplayName ("E-mail") ]
        public string emailEt{ get; set;}

        [Required]
        public int idclasse{get; set;}

        [ForeignKey("id")]
        public Classe classe{get; set;}
     

 
    }
}