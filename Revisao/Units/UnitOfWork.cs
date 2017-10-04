using Revisao.Persistencia;
using Revisao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revisao.Units
{
    public class UnitOfWork : IDisposable
    {

        private EmpresarialContext _context = new EmpresarialContext();

        private IEmpresaRepository _empresaRepository;
        private IFuncionarioRepository _funcionarioRepository;
        public IEmpresaRepository EmpresaRepository
        {

            get
            {
                if(_context == null)
                {
                    _empresaRepository = new EmpresaRepository(_context);
                }
                return _empresaRepository;
            }

        }

        public IFuncionarioRepository funcionarioRepository
        {
            get
                {
                if(_context == null)
                {
                    _funcionarioRepository = new FuncionarioRepository(_context);
                }
                return _funcionarioRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}