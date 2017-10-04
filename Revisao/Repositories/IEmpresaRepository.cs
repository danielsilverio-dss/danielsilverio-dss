using Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Repositories
{
    public interface IEmpresaRepository
    {
        void Salvar(Empresa empresa);
        List<Empresa> Listar();
    }
}
