using System;
using DTO.Interface;

namespace DTO
{
    public class IdiomaDTO : BaseDTO, IDisposable, INomeado
    {
        public IdiomaDTO()
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