using System;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Interfaces;
using System.Linq;

namespace ControleFinanceiro.Infrastrucure.Data.Repositories
{
    public class UsuarioRepository : BaseRpository<Usuario>, IUsuarioRepository
    {
        public Usuario ObterPorLoginESenha(string login, string senha)
        {
            return Contexto.Usuarios.FirstOrDefault(u => u.Login.Equals(login)
                                                      && u.Senha.Equals(senha));
        }

        public Usuario ObterPorEmail(string email)
        {
            return Contexto.Usuarios.FirstOrDefault(u => u.Email.Equals(email));
        }
    }
}
