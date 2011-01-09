using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_de_Ponto.Dominio
{
    public class Projeto
    {
        public Cliente cliente;
        private String _nome;
        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new Exception("Nome do Projeto não pode ser vazio");
                _nome = value;
            }
        }
        public Projeto(Cliente cliente_do_projeto, String nome_do_projeto)
        {
            cliente = cliente_do_projeto;
            Nome = nome_do_projeto;
        }
    }
}
