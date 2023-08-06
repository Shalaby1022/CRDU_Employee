using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CRDU_eMP.ViewModel
{
    public class AddEmpView
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be from 3 to 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(20, 60, ErrorMessage = "20 to 60 ")]
        public int Age { get; set; }

        public int Salary { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [RegularExpression(".*@[a-z0-9.-]*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password, ErrorMessage = "Password must have" +
            "must contains one digit from 0-9\r\n  " +
            "must contains one lowercase characters\r\n  " +
            "must contains at least one special character\r\n " +
            "match anything with previous condition checking\r\n" +
            "length at least 8 characters and maximum of 20")]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\\W]).{6,20})")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Does not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Office")]
        public int Off_Id { get; set; }
        [ValidateNever]
        public SelectList Offices { get; set; }


    }
}

