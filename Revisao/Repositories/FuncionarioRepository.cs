using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Revisao.Models;
using Revisao.Persistencia;

namespace Revisao.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private EmpresarialContext _context;

        public FuncionarioRepository(EmpresarialContext context)
        {
            _context = context;
        }

        public List<Funcionario> Listar()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}