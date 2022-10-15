﻿using System.ComponentModel.DataAnnotations;

namespace ChapterBET6.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informo e-amil do usuario")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuario")]
        public string senha { get; set; }
    }
}
