using System;

namespace DTO
{
    public class LocalidadeDTO : BaseDTO, IDisposable
    {
        public LocalidadeDTO()
        {
            Nome = string.Empty;
            Descricao = string.Empty;
            Mapa = string.Empty;
        }
        public string Nome { get; set;}
        public string Descricao { get; set; }
        public string Mapa { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public void Dispose()
        {
            Nome = null;
            Descricao = null;
            Mapa = null;
        }
    }
}