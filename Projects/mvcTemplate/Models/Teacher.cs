using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace mvc.Models;

public class Teacher : IdentityUser
{
    // [Required(ErrorMessage = "L'identifiant est obligatoire")]
    // [Display(Name = "Identifiant")]
    // public int Id { get; set; }

    [StringLength(20, MinimumLength = 5)]
    public string Lastname { get; set; }
    public string Firstname { get; set; }

    // [Required]
    // [EmailAddress]
    // public string Email { get; set; }

    [Required]
    [Url]
    public string PersonalWebSite { get; set; }


}