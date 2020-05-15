using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace Project.Models
{
    public class MatiereProf 
    {
        [Key]
        public int Id{get; set;}

        [DisplayName ("Matiére") ]
        
        public string Nom{get; set;}

   
         



    
    }
}