using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project.Models
{
    public class Absence
    {
         [Key]
        public int id { get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Nom etudiant") ]
        
        public string Nomet{ get; set;}

        [Required(ErrorMessage="Ce champ est obligatoire!")]
        [DisplayName ("Prénom etudiant") ]
        
        public string prenomet{ get; set;}
        


       
       

     
   
    }
}