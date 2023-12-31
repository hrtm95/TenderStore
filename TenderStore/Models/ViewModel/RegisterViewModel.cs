﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TS.Endpoints.UI.Models.ViewModel
{
    public class RegisterViewModel
    {
        [BindProperty]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [EmailAddress(ErrorMessage = "* آدرس ایمیل معتبر نمی باشد")]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [StringLength(16, ErrorMessage = "* کلمه عبور باید حداقل 4 و حداکثر 16 کاراکتر باشد", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [Display(Name = "تکرار رمز عبور")]
        [Compare(nameof(Password), ErrorMessage = "* کلمه عبور و تکرار آن باید برابر باشند")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
