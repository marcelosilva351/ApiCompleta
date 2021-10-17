using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using AutoMapper;
using Data.DTO_S.ProdutoDTO;
using Business.Model;

namespace ApiPires.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(ProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }


        [HttpPost("AdicionarProduto")]
        public async Task<ActionResult> AdicionarProduto([FromBody]CreateProdutoDTO createProdutoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var produtoAdd = _mapper.Map<Produto>(createProdutoDTO);
            try
            {
                await _produtoService.AdicionarProduto(produtoAdd);
                return CreatedAtAction(nameof(ObterProduto), new { id = produtoAdd.Id }, produtoAdd);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        [Route("ObterProduto")]
        public async Task<ActionResult<ReadProdutoDTO>> ObterProduto(int id)
        {
            var produto = await _produtoService.ObterProduto(id);
            if(produto == null)
            {
                return NotFound("Produto não encontrado");
            }
            var produtoReadDTO = _mapper.Map<ReadProdutoDTO>(produto);
            return produtoReadDTO;
        }

        [HttpGet("ObterProdutos")]

        public async Task<ActionResult<List<ReadProdutoDTO>>> ObterProdutos()
        {
            var produtos = await _produtoService.ObterProdutos();
            if(produtos == null)
            {
                return NotFound("Tabela de produtos vazia");
            }
            var produtosReadDTO = _mapper.Map<List<ReadProdutoDTO>>(produtos);
            return produtosReadDTO;
        }

        [HttpGet("{id}")]
        [Route("ObterProdutosPorFornecedor")]
        public async Task<ActionResult<List<ReadProdutoDTO>>> ObterProdutosPorFornecedor(int id)
        {
            var ProdutosDoFornecedor = await _produtoService.ObterProdutosPorFornecedor(id);
            if(ProdutosDoFornecedor == null)
            {
                return NotFound("FornecedorSemProdutos");
            }
            var produtosFornecedorRead = _mapper.Map<List<ReadProdutoDTO>>(ProdutosDoFornecedor);
            return produtosFornecedorRead;
            

        }

    }


}
