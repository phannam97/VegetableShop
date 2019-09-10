using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Vui lòng điền họ và tên", AllowEmptyStrings = false)]
        [Display(Name = "Full name")]
        public string FullName { set; get; }

        [Required(ErrorMessage = "Vui lòng điền tên tài khoản", AllowEmptyStrings = false)]
        [Display(Name = "User name")]
        public string UserName { set; get; }

        [Display(Name = "DOB")]
        public DateTime? BirthDay { set; get; }

        [Required(ErrorMessage = "Vui lòng điền mail", AllowEmptyStrings = false)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng điền mật khẩu", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = " {0} có ít nhât {2} và dài nhât {1} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng điền địa chỉ", AllowEmptyStrings = false)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng điền số điện thoại", AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "Số điện thoại không đúng")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { set; get; }
    }
}
