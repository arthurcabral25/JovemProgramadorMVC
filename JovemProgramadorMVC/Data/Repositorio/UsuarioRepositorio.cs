using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public bool BuscarUsuario(Usuario usuario)
        {
            var usuarios = _bancoContexto.Usuario.ToList();
            foreach (Usuario user in usuarios)
            {
                if (usuario.Email == user.Email && usuario.Senha == user.Senha) return true;
            }
            return false;
        }
    }
}
