using System;
namespace DTO.Dominio
{
    public class PessoaConsulta : IDisposable
    {
        public PessoaConsulta()
        {
            Nome = string.Empty;
            Apelido = string.Empty;
        }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        
        public void Dispose()
        {
            Nome = null;
            Apelido = null;
        }
    }
}