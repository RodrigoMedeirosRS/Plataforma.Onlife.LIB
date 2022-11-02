using System;

namespace BibliotecaViva.DTO
{
    public class Localidade : BaseDTO, IDisposable
    {
        public Localidade()
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