using System;
using System.Collections.Generic;

using DTO.Utils;
using DTO.Interface;

namespace DTO
{
    public class RegistroDTO : BaseDTO, IDisposable, INomeado
    {
        public RegistroDTO()
        {
            Nome = string.Empty;
            Apelido = string.Empty;
            Idioma = string.Empty;
            Tipo = string.Empty;
            Conteudo = string.Empty;
            Descricao = string.Empty;
            DataInsercao = DateTime.Now;
            Referencias = new List<RelacaoDTO>();
        }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Idioma { get; set; }
        public string Tipo { get; set; }
        public string Conteudo { get; set; }
        public string Descricao { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int CodigoCidade { get; set; }
        public DateTime DataInsercao { get; set; }
        public List<RelacaoDTO> Referencias { get; set; }

        public void Dispose()
        {
            Nome = null;
            Apelido = null;
            Idioma = null;
            Tipo = null;
            Conteudo = null;
            Descricao = null;
            Desalocador.DesalocarLista<RelacaoDTO>(Referencias);
        }
    }
}