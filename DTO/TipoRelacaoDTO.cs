using System;
using DTO.Interface;

namespace DTO
{
    public class TipoRelacaoDTO : BaseDTO, IDisposable, INomeado
    {
        public TipoRelacaoDTO()
        {
            Nome = string.Empty;
        }
        public string Nome { get; set; }

        public void Dispose()
        {
            Nome = null;
        }
    }
}