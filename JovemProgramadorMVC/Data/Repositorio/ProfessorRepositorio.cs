using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.Data.Repositorio
{
    public class ProfessorRepositorio: IProfessorRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public ProfessorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Professor> BuscarProfessores()
        {
            return _bancoContexto.Professor.ToList();
        }
    }
}
