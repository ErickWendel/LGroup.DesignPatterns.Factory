using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.DataTransferObject.Base
{
    //os campos em comum para os dois tipos de clientes

   public abstract class ClienteDTO
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Saudacao { get; set; }
        public DateTime DataAcesso { get; set; }
        
        //s'o quem tiver na propria DLL
        //para garantir que ninguem vai tentar dar new
        //nos clientes sem passar pela fabrica
        //deixamos o construtor como internal
        internal ClienteDTO()
        {

        }
    }
}
