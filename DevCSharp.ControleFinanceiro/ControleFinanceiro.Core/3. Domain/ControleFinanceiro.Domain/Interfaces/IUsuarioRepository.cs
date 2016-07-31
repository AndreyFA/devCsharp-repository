using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario ObterPorLoginESenha(string login, string senha);
        Usuario ObterPorEmail(string email);
    }
}
