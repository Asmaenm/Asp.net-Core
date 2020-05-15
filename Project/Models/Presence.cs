using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project.Models
{
    public class Presence
    {
        [Key]
        public int id { get; set;}
        
        [Required]
        public string Nomet{ get; set;}
        [Required]
        public string prenomet{ get; set;}
        
        

    }
}