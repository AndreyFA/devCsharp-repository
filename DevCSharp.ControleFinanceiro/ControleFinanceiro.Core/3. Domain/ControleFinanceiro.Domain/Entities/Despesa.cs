using System;

namespace ControleFinanceiro.Domain.Entities
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; protected set; }

        public void AssociarUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
    }
}
