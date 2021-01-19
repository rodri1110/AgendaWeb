using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} obrigatório")]
        [Range(10900000000, 99999999999, ErrorMessage = "{0} deve conter o ddd seguido de 9 dígitos")]
        public long Telefone { get; set; }
        public string Endereco { get; set; }

        public Contato()
        {
        }

        public Contato(int id, string nome, long telefone, string endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
