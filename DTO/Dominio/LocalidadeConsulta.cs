using System;

namespace DTO.Dominio
{
    public class LocalidadeConsulta : IDisposable
    {
        public LocalidadeConsulta()
        {
            Nome = string.Empty;
        }
        public int Codigo { get; set;}
        public string Nome { get; set; }
        public bool Completo { get; set; }

        public void Dispose()
        {
            Nome = string.Empty;
        }
    }
}