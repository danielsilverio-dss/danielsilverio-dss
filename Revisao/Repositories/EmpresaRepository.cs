using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Revisao.Models;
using System.Runtime.Remoting.Contexts;
using Revisao.Persistencia;

namespace Revisao.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private EmpresarialContext _context;
        public EmpresaRepository(EmpresarialContext context) {
            _context = context;
        }
        public List<Empresa> Listar()
        {
            return _context.Empresas.ToList();
        }

        public void Salvar(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
        }
    }
}