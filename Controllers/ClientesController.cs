using LH_Pets.Data;
using LH_Pets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LH_Pets.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    // GET /api/clientes
    // Retorna todos os clientes cadastrados.
    [HttpGet]
    public ActionResult<List<Cliente>> ListarClientes()
    {
        return Ok(DadosEmMemoria.Clientes);
    }

    // POST /api/clientes
    // Cadastra um novo cliente.
    [HttpPost]
    public ActionResult<Cliente> CadastrarCliente(Cliente cliente)
    {
        // O Id é gerado pela API, ignorando qualquer valor enviado na requisição.
        cliente.Id = DadosEmMemoria.ProximoClienteId;
        DadosEmMemoria.ProximoClienteId++;

        DadosEmMemoria.Clientes.Add(cliente);

        // 201 Created: indica que um novo registro foi criado.
        return StatusCode(StatusCodes.Status201Created, cliente);
    }
}
