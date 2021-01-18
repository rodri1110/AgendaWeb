using System;

namespace AgendaWeb.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }

        public Contato()
        {
        }

        public Contato(int id, string nome, int telefone, string endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
