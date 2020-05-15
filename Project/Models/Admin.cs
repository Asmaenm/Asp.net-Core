using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project.Models
{
    public class Admin
    {
        [Key]
        public int id{ get; set;}

        [Required]
        public string nomAd{ get; set;}

        [Required]
        public string prenomAd{ get; set;}

        [Required]
        public int tel{ get; set;}

        [Required]
        public string emailAd{ get; set;}
    }
}