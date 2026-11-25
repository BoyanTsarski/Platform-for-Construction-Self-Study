using System.ComponentModel.DataAnnotations;

namespace ConstructionSelfStudy.Web.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Въведете имената си.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Името трябва да е между 2 и 100 символа.")]
    [Display(Name = "Име")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Въведете имейл.")]
    [EmailAddress(ErrorMessage = "Невалиден имейл.")]
    [Display(Name = "Имейл")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Въведете парола.")]
    [DataType(DataType.Password)]
    [Display(Name = "Парола")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Потвърдете паролата.")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Паролите не съвпадат.")]
    [Display(Name = "Потвърди паролата")]
    public string ConfirmPassword { get; set; } = string.Empty;
}