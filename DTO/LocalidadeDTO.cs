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
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public void Dispose()
        {
            Nome = null;
            Descricao = null;
            Mapa = null;
        }
    }
}