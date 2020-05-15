using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Publication
    {
        [Key]
        public int Id{get; set;}

        [Required]
        public string contenu{get; set;}

        [DataType(DataType.Date)]
         public string datePub{get; set;}

        [Required]
         public int IdClasse{get; set;}

         [ForeignKey("Id")]
         public Classe classe{ get; set;}
    }
}