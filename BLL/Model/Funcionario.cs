using System;
namespace BLL.Model
{
    public class Funcionario
    {
        public int    Id { get; set; }
        public string CodigoRegistro { get; set; }
        public string Nome { get; set; }
        public string dtCadastro { get; set; }


        public Funcionario()
        {
        }
    }
}
