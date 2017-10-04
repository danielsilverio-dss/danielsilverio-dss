using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revisao.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public List<Funcionario> Funcionarios { get; set; }
    }
}