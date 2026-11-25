using System.ComponentModel.DataAnnotations;

namespace ConstructionSelfStudy.Web.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Въведете имейл.")]
    [EmailAddress(ErrorMessage = "Невалиден имейл.")]
    [Display(Name = "Имейл")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Въведете парола.")]
    [DataType(DataType.Password)]
    [Display(Name = "Парола")]
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Запомни ме")]
    public bool RememberMe { get; set; }
}