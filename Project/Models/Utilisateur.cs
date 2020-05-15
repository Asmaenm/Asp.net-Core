
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Utilisateur: IdentityUser
    {
    public string nom{ get; set;}
    public string prenom{ get; set;}
    
    public char status{ get; set;}

    
    }
}