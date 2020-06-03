using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WikiVerde.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo Nome Completo é obrigatório.")]
        [Display(Name = "Nome Completo")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [Display(Name = "CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo RG é obrigatório.")]
        [Display(Name = "RG")]
        public string RG { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

    }
}
