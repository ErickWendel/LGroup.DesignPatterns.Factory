
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.DataTransferObject
{
    public sealed class ClienteJuridicoDTO: Base.ClienteDTO
    {
        public String Cnpj { get; set; }
        public DateTime DataAbertura { get; set; }
        public String RazaoSocial { get; set; }

        internal ClienteJuridicoDTO()
        {

        }
    }
}
