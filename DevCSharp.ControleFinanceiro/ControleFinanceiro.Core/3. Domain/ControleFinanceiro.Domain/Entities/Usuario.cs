using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; protected set; }
        public string Email { get; set; }
        public string Login { get; protected set; }
        public string Senha { get; protected set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataUltimoAcesso { get; set; }
        public virtual IEnumerable<Despesa> Despesas { get; protected set; }

        public bool TrocarSenha()
        {
            return (DateTime.Now.Month - DataUltimoAcesso.Month) >= 3;
        }

        public static class Factory
        {
           public static Usuario CriarUsuario(string nomeCompleto, string login, string senha)
            {
                return new Usuario
                {
                    NomeCompleto = nomeCompleto,
                    Login = login,
                    Senha = senha
                };
            }
        }
    }
}
