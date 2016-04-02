using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LGroup.DataTransferObject;


namespace LGroup.Factory.Test
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void Testar_Cliente_Sem_Factory()
        {
            //Inicializamos a classe Cliente
            //agora vai dar pau pois est'a com construtor internal
            //var cliente = new ClienteFisicoDTO();
            //cliente.Codigo = 1;
            //cliente.DataAcesso = DateTime.Now;
            //cliente.Saudacao = "Seja Bem Vindo";
        }

        [TestMethod]
        public void Testar_Cliente_Com_Factory()
        {
            //eu programador nao preciso saber como inicializa
            //a classe e configurar a classe
            //ja recebeo ela previamente
            //inicializada e configurada
            var cliente = ClienteFactory.Criar(1);

        }
    }
}
