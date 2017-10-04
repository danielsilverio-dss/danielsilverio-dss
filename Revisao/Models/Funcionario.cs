using System;
using System.ComponentModel.DataAnnotations;

namespace Revisao.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Salario { get; set; }
        public DateTime DataAdmissão { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; } // opcional
    }
}