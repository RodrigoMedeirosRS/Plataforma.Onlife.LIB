using System;
using DTO.Interface;

namespace DTO
{
    public class NomeSocialDTO : BaseDTO, IDisposable, INomeado
    {
        public NomeSocialDTO()
        {
            Nome = string.Empty;
        }
        public int Pessoa { get; set; }
        public string Nome { get; set; }

        public void Dispose()
        {
            Nome = null;
        }
    }
}