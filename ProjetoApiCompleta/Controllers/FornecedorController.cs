using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using Business.Model;
using Data.DTO_S.FornecedorDTO;
using Business.Interfaces;
using Data.DTO_S.EnderecoDTO;

namespace ApiPires.Controllers
{
    [ApiController]
    [Route("api/fornecedore")]
    public class FornecedorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IMapper mapper, IFornecedorService fornecedorService)
        {
            _mapper = mapper;
            _fornecedorService = fornecedorService;
        }

        [HttpGet("GetFornecedores")]
        public async Task<ActionResult<List<ReadFornecedorDTO>>> ObterFornecedores()
        {

            var fornecedores = await _fornecedorService.ObterFornecedores();
            if (fornecedores == null)
            {
                return NotFound("Banco de dados sem fornecedores");
            }
            var fornecedoresReadDTO = _mapper.Map<List<ReadFornecedorDTO>>(fornecedores);

            return fornecedoresReadDTO;
        }
        [HttpGet("{id}")]
        [Route("GetFornecedor")]
        public async Task<ActionResult<ReadFornecedorDTO>> ObterFornecedor(int id)
        {
            var fornecedor = await _fornecedorService.ObterFornecedor(id);
            if(fornecedor == null)
            {
                return NotFound("Fornecedor não existe no banco de dados");
            }
            var readfornecedor =_mapper.Map<ReadFornecedorDTO>(fornecedor);
            return readfornecedor;
        }

        [HttpPost("PostFornecedor")]
        public async Task<ActionResult> CadastrarFornecedor([FromBody] CreateFornecedorDTO fornecedorAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var fornecedor =_mapper.Map<Fornecedor>(fornecedorAdd);
            try
            {
               await _fornecedorService.AdicionarFornecedor(fornecedor);
                return CreatedAtAction(nameof(ObterFornecedor), new { id = fornecedor.Id }, fornecedor);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message );
            }
        }

        [HttpPut("{id}")]
        [Route("AdicionarEnderecoFornecedor")]
        public async Task<ActionResult> AdicionarEndereco(int id, [FromBody] EnderecoDTO enderecoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var enderecoAdd = _mapper.Map<Endereco>(enderecoDTO);
            try
            {
                await _fornecedorService.AdicionarEndereco(id, enderecoAdd);
                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest("Não foi possivel adicionar o endereço");
            }

        }

        [HttpPut("{id}")]
        [Route("AtualizarFornecedor")]
        public async Task<ActionResult> AtualizarFornecedor(int id, [FromBody] CreateFornecedorDTO fornecedorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var fornecedor = await _fornecedorService.ObterFornecedor(id);
            fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
            try
            {
                await _fornecedorService.AtualiarFornecedor(fornecedor);
                return NoContent();

            }
            catch (Exception)
            {

                return BadRequest("Não foi possivel atualizar o fornecedor");
            }

            
        }

        [HttpGet("{id}")]
        [Route("ObterFornecedorEndereco")]
        public async Task<ActionResult<ReadFornecedorDTO>> ObterFornecedorEndereco(int id)
        {
            var fornecedorEndereco = await _fornecedorService.ObterFornecedorEndereco(id);
            if(fornecedorEndereco == null)
            {
                return NotFound("Fornecedor não encontrado");
            }
            var fornecedorReadDTO = _mapper.Map<ReadFornecedorDTO>(fornecedorEndereco);
            return fornecedorReadDTO;
        }

        [HttpGet("ObterFornecedoresInclude")]
        public async Task<ActionResult<List<ReadFornecedorDTO>>> ObterFornecedoresInclude()
        {
            var fornecedoresInclude = await _fornecedorService.ObterFornecedoresProdutosEndereco();
            if(fornecedoresInclude == null)
            {
                return NotFound("Tabela de fornecedores vazia");
            }
            var forncedoresIncludeReadDTO = _mapper.Map<List<ReadFornecedorDTO>>(fornecedoresInclude);
            return forncedoresIncludeReadDTO;
        }
        


    }
}
