using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WikiVerde.Models
{
    public class Login : Usuario
    {
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public DateTime DataAcesso { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
