
//Validation Attribute in ASP.NET Core...
//using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Core_Empty.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is must!!!")] // it validates that the field is not null....
        [StringLength(15, MinimumLength = 3)]
        [Column("StudentName", TypeName = "varchar(20)")] // this is the part of EF Core
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is must!!!")]
        [Range(18, 60, ErrorMessage = "Age must be in the range 18 and 60!")]// this annotation property only works with NULL values...
        public int Age { get; set; } // int? means this integer variable can hold null values also... 

        [Required(ErrorMessage = "Gender is must!!!")]
        [Column("StudentGender", TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "standard is must!!!")]
        public int Standard { get; set; }

        //[Required(ErrorMessage = "Email is must!!!")]
        ////[EmailAddress]
        //[RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Password is must!!!")]
        ////[Range(8, 15)]
        //[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Range must be 8 and 15!, must include : Uppercase, Lowercase, Number, Special Symbols...")] // this is Strong Password code
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Confirm Password is must!!!")]
        ////[Range(8, 15)]
        ////[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Range must be 8 and 15!, must include : Uppercase, Lowercase, Number, Special Symbols...")] // this is Strong Password code
        //[Compare("Password", ErrorMessage = "Password and Confirm password must be same!!")]
        //public string ConfirmPass { get; set; }

        //[Required(ErrorMessage = "Website URL is must!!!")]
        //[Url(ErrorMessage = "Invalid URL, try again!")]
        //public string WebURL { get; set; }

        //[Required(ErrorMessage = "Profile Summary is must!!!")]
        //[MaxLength(50)]
        //[MinLength(5)]
        //public string ProfileSum { get; set; }  
    }
}
