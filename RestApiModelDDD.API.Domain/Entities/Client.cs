using System;

namespace RestApiModelDDD.Domain.Entities
{
    public class Client : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Datacadastro{ get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool ativo { get; set; }
    }
}
