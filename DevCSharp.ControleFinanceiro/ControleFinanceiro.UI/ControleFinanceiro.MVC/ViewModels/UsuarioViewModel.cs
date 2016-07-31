using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Preencha o email.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha a senha.")]
        public string Senha { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [ScaffoldColumn(false)]
        public DateTime DataUltimoAcesso { get; set; } = DateTime.Now;
    }
}