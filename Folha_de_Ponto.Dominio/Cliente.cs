using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_de_Ponto.Dominio
{
    public class Cliente
    {
        private String _telefone;
        public String Telefone
        {
            get
            {
                return _telefone;
            }
            set 
            {
                if (value.Length > 15) throw new Exception("Numero do telefone não pode conter mais de 15 caracteres");
                _telefone = value;
            }
        }
        private String _nome;
        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new Exception("Nome do Cliente não pode ser vazio");
                _nome = value;
            }
        }
        public string _projetos;

        public Cliente(String nome_do_cliente)
        {
            Nome = nome_do_cliente;
        }
        public string[] listar_projetos(){
            String[] Projetos = new string[]{_projetos.Substring(0,_projetos.Length-1)} ;
           
                return Projetos;
           
        }
    }
}
