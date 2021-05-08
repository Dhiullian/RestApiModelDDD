namespace RestApiModelDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Nome { get; set; }
        public string valor { get; set; }
        public bool disponivel { get; set; }
    }
}
