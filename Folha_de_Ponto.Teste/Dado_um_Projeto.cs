using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Folha_de_Ponto.Dominio;

namespace Folha_de_Ponto.Teste
{
    [TestClass]
    public class Dado_um_Projeto
    {
        [TestMethod]
        public void todo_projeto_tem_cliente_e_nome()
        {
            Cliente cliente = new Cliente("Gupo de estudos");
            Projeto projeto = new Projeto(cliente, "teste");
            Assert.AreEqual(cliente, projeto.cliente);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))] 
        public void nome_do_projeto_nao_pode_ser_vazio()
        {
            Cliente cliente = new Cliente("Gupo de estudos");
            Projeto projeto = new Projeto(cliente, "");
            Assert.AreEqual(cliente, projeto.cliente);
        }
    }
}