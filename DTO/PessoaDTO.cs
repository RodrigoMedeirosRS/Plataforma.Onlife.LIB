using System;
using System.Collections.Generic;

using DTO.Interface;
using DTO.Utils;

namespace DTO
{
    public class PessoaDTO : BaseDTO, IDisposable, INomeado
    {
        public PessoaDTO()
        {
            Nome = string.Empty;
            Apelido = string.Empty;
            Foto = string.Empty;
            ResearchGate = string.Empty;
            LinkedIn = string.Empty;
            Lattes = string.Empty;
            Relacoes = new List<RelacaoDTO>();
        }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Foto { get; set; }
        public string ResearchGate { get; set; }
        public string LinkedIn { get; set; }
        public string Lattes { get; set; }
        public List<RelacaoDTO> Relacoes { get; set; }

        public void Dispose()
        {
            Nome = null;
            Apelido = null;
            Foto = null;
            ResearchGate = null;
            LinkedIn = null;
            Lattes = null;
            Desalocador.DesalocarLista<RelacaoDTO>(Relacoes);
        }
    }
}