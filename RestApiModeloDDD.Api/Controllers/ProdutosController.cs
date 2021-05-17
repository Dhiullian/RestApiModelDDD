using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Api.Controllers
{
    [Route("produto/")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;
        
        public ProdutosController(IApplicationServiceProduto applicationServiceProduto)
        {
            this._applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.getById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
