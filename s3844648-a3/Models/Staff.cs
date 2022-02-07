using System.ComponentModel.DataAnnotations;

namespace s3844648_a3.Models;
public class Staff
{
    [StringLength(6)]
    [RegularExpression(@"^(^\e[0-9]{5})$", ErrorMessage = "Must start with e and be followed by 5 digits")]

    public string StaffID { get; set; }

    [StringLength(30)]
    [RegularExpression(@"^(^[A-Z][a-z]+$)$", ErrorMessage = "Must start with an upper-case letter and only contain letters")]
    public string FirstName { get; set; }

    [StringLength(30)]
    [RegularExpression(@"^(^[A-Z][a-z]+$)$", ErrorMessage = "Must start with an upper-case letter and only contain letters")]
    public string LastName { get; set; }

    [StringLength(320)]
    //source: https://www.w3resource.com/javascript/form/email-validation.php
    [RegularExpression(@"^(^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$)$", ErrorMessage = "Must be a valid email address")]
    public string Email { get; set; }

    [StringLength(10)]
    [RegularExpression(@"^(^04[0-9]{8})$", ErrorMessage = "Must start with 04 and be followed by 8 digits")]
    public string? MobilePhone { get; set; }
}