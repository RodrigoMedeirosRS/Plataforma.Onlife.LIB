using System;

namespace DTO.Dominio
{
    public class VincularRegistroLocalidade : IDisposable
    {
        public VincularRegistroLocalidade()
        {
            Localidade = new LocalidadeDTO();
            Registro = new RegistroDTO();
        }
        public LocalidadeDTO Localidade { get; set; }
        public RegistroDTO Registro { get; set; }

        public void Dispose()
        {
            Localidade.Dispose();
            Registro.Dispose();
        }
    }
}