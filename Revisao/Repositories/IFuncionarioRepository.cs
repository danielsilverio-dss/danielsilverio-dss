using Revisao.Models;
using Revisao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revisao.Repositories
{
    public interface IFuncionarioRepository
    {
        void Salvar(Funcionario funcionario);
        List<Funcionario> Listar();
    }
}