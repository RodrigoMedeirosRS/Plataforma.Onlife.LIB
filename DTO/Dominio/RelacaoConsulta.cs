using System;

namespace DTO.Dominio
{
    public class RelacaoConsulta : IDisposable
    {
        public RelacaoConsulta()
        {
            
        }
        public RelacaoConsulta(int codigoRegistro)
        {
            CodRegistro = codigoRegistro;
        }
        public int CodRegistro { get; set; }

        public void Dispose()
        {
            CodRegistro = 0;
        }
    }
}