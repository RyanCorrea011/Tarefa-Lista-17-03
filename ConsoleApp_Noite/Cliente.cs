using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;

        public Cliente(int id,
                        string nome,
                            string telefone,
                                Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setNome(string nome)
        {
            if(nome != "")
            {
                Nome = nome;
            }
        }
        public string getNome()
        {
            return Nome;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
