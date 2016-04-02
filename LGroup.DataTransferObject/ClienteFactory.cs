using LGroup.DataTransferObject.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//um dos padroes mais usados do mundo, 'e o padrao 
//Factory (FABRICA) (GOF -= 5)
//Criamos umaclasse para construir, gerar outras classes
//A proposta deste padrao, 'e evitar repetir a inicializacao  
//de classes
//com a farcua , os programdores recebem as classes
//inicializadas e ja configurados, ele so tem que usar
//o programsodr nao precisa saber como a classe foi gerada

namespace LGroup.DataTransferObject
{
    //Quando a classe nao tem variaveis ou propriedades
    //os comandos podem ser STATIC
   public sealed  class ClienteFactory
    {

        //Simulando uma fabrica de geracao de clientes
        //1 = fisico
        //2 = juridico


        public static ClienteDTO Criar(Int32 tipoCliente_)
        {
            //PRINCIPIO DE LISKOV
            ClienteDTO cliente;
            if (tipoCliente_ == 1)
                cliente = new ClienteFisicoDTO();
            else
                cliente = new ClienteJuridicoDTO();

            cliente.Codigo = 1;
            cliente.DataAcesso = DateTime.Now;
            cliente.Saudacao = "Seja Bem vindo";
            return cliente;  
        }
    }
}
