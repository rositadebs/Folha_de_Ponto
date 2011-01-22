using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Folha_de_Ponto.Dominio;

namespace Folha_de_Ponto.Teste
{
    [TestClass]
    public class Dado_um_Funcionário
    {
       
        [TestMethod]
        public void não_pode_criar_funcionário_sem_nome_e_identificação()
        {
            String nome_do_funcionario = "Luiz Perreira";
            String id = "666";
            Funcionário funcionario = new Funcionário(nome_do_funcionario,id);
            Assert.AreEqual(nome_do_funcionario, funcionario.Nome);
        }
        
    }
}
