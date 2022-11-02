using System;

namespace DTO.Dominio
{
    public class ReferenciaConsulta : IDisposable
    {
        public int Registro { get; set; }
        
        public void Dispose()
        {
        }
    }
}