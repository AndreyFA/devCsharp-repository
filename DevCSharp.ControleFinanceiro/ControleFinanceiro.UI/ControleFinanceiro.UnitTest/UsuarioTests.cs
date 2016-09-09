using ControleFinanceiro.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleFinanceiro.UnitTest
{
    [TestClass]
    public class UsuarioTests
    {
        [TestInitialize]
        public void UsuarioTestsInitialize()
        {

        }

        [TestMethod]
        public void DeveSerPossivelCriarUmUsuario()
        {
            var usuario = Usuario.Factory.CriarUsuario("usuario1", "usuario1", "usuario1Senha");

            Assert.IsNotNull(usuario.DataCadastro);
        }

        [TestCleanup]
        public void UsuarioTestsCleanup()
        {

        }
    }
}
