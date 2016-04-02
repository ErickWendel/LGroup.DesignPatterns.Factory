using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.DataTransferObject
{
  public sealed   class ClienteFisicoDTO : Base.ClienteDTO
    {
        //Palavras de at'e 2 caracteres, TUDO maiusculo
        public String RG { get; set; }
        public String Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        internal ClienteFisicoDTO()
        {

        }
    }
}
