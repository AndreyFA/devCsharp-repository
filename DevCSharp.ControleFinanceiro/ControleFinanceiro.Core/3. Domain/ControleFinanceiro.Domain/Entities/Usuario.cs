using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public virtual IEnumerable<Despesa> Despesas { get; protected set; }

        public bool TrocarSenha()
        {
            return (DateTime.Now.Month - DataUltimoAcesso.Month) >= 3;
        }
    }
}
