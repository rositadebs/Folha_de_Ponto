﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Folha_de_Ponto.Dominio;

namespace Folha_de_Ponto.Teste
{
    [TestClass]
    public class Dado_Um_Cliente
    {
        
       

        [TestMethod]
        public void não_pode_criar_cliente_sem_nome()
        {
            String nome_do_cliente = "Grupo de Estudos";
            Cliente cliente = new Cliente(nome_do_cliente);
            Assert.AreEqual(nome_do_cliente, cliente.Nome);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void nome_do_cliente_não_pode_ser_vazio()
        {
            String nome_do_cliente = "";
            Cliente cliente = new Cliente(nome_do_cliente);
        }
        [TestMethod]
        public void posso_informar_telefone_do_cliente()
        {
            String telefone_do_cliente = "5555555555555";
            Cliente cliente = new Cliente("o");
            cliente.Telefone = telefone_do_cliente;
            Assert.AreEqual(telefone_do_cliente,cliente.Telefone);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void telefone_do_cliente_não_pode_ter_mais_de_17_caracteres()
        {
            String telefone_do_cliente = "555555555555555555555555";
            Cliente cliente = new Cliente("o");
            cliente.Telefone = telefone_do_cliente;
        }
        [TestMethod]
        public void eh_possivel_listar_projetos_do_cliente()
        {
            String nome_do_projeto = "TimeSheet";
            string[] lista_projetos = new string[]{"TimeSheet,teste"};
            String nome_do_cliente = "Grupo de Estudo";
            Cliente meu_cliente = new Cliente(nome_do_cliente);
            Projeto projeto = new Projeto(meu_cliente, nome_do_projeto);
            Projeto novo = new Projeto(meu_cliente, "teste");
           Assert.IsTrue (ArrayCompare(lista_projetos, meu_cliente.listar_projetos()));
        }
        public static bool ArrayCompare(string[] arrayA, string[] arrayB)
        {
            if (arrayA.Length != arrayB.Length)
            {
                return false;
            }
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] != arrayB[i])
                {
                    return false;
                }
            }
            return true;
        } 

   
    }
}
