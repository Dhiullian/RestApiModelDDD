using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Dto
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
