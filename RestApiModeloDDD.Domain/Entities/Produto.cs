namespace RestApiModeloDDD.Domain.Entities
{
    public class Produto: Base
    {
        public string nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }

    }
}
