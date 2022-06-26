using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Gabriel", Senha = "abc123"},
            new Usuario(){Nome = "Cesar", Senha = "123abcd"},
            new Usuario(){Nome = "Julia", Senha = "123abc"},
            new Usuario(){Nome = "Artur", Senha = "abcd123"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado { get { return _userLogado; } private set { _userLogado = value; } }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == nome)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
