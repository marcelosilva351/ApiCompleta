using AutoMapper;
using Business.Interfaces;
using Data.DTO_S.ClienteDTO_S;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPires.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        [HttpGet("GetClientes")]
        public async Task<ActionResult<List<ReadClienteDTO>>> ObterClientes()
        {

            var fornecedores = await _clienteService.ObterClientes();
            if (fornecedores == null)
            {
                return NotFound("Banco de dados sem fornecedores");
            }
            var ClienteReadDTO = _mapper.Map<List<ReadClienteDTO>>(fornecedores);

            return ClienteReadDTO;
        }
        [HttpGet("{id}")]
        [Route("GetCliente")]
        public async Task<ActionResult<ReadClienteDTO>> ObterCliente(int id)
        {
            var fornecedor = await _clienteService.ObterCliente(id);
            if (fornecedor == null)
            {
                return NotFound("Cliente não existe no banco de dados");
            }
            var ClienteRead = _mapper.Map<ReadClienteDTO>(fornecedor);
            return ClienteRead;
        }

        [HttpPost("PostFornecedor")]
        public async Task<ActionResult> CadastrarFornecedor([FromBody] CreateClienteDTO ClienteADD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var fornecedor = _mapper.Map<Fornecedor>(ClienteADD);
            try
            {
                await _fornecedorService.AdicionarFornecedor(fornecedor);
                return CreatedAtAction(nameof(ObterFornecedor), new { id = fornecedor.Id }, fornecedor);
            }
    }
}
