
//Validation Attribute in ASP.NET Core...
//using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace ASP_Core_Empty.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is must!!!")] // it validates that the field is not null....
        [StringLength(15, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is must!!!")]
        //[EmailAddress]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is must!!!")]
        [Range(18,60, ErrorMessage ="Age must be in the range 18 and 60!")]// this annotation property only works with NULL values...
        public int? Age { get; set; } // int? means this integer variable can hold null values also... 
            
        [Required(ErrorMessage = "Password is must!!!")]
        //[Range(8, 15)]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Range must be 8 and 15!, must include : Uppercase, Lowercase, Number, Special Symbols...")] // this is Strong Password code
        public string Password { get; set; }
        
    }
}
