using LH_Pets.Data;
using LH_Pets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LH_Pets.Controllers;

[ApiController]
[Route("api/pets")]
public class PetsController : ControllerBase
{
    // GET /api/pets
    // Retorna todos os pets cadastrados.
    [HttpGet]
    public ActionResult<List<Pet>> ListarPets()
    {
        return Ok(DadosEmMemoria.Pets);
    }

    // POST /api/pets
    // Cadastra um novo pet, desde que o cliente informado exista.
    [HttpPost]
    public ActionResult<Pet> CadastrarPet(Pet pet)
    {
        bool clienteExiste = DadosEmMemoria.Clientes.Any(c => c.Id == pet.ClienteId);

        if (!clienteExiste)
        {
            // 404 Not Found: o cliente informado não está cadastrado.
            return NotFound($"Cliente com Id {pet.ClienteId} não foi encontrado.");
        }

        pet.Id = DadosEmMemoria.ProximoPetId;
        DadosEmMemoria.ProximoPetId++;

        DadosEmMemoria.Pets.Add(pet);

        return StatusCode(StatusCodes.Status201Created, pet);
    }

    // GET /api/pets/cliente/{clienteId}
    // Retorna apenas os pets do cliente informado.
    [HttpGet("cliente/{clienteId}")]
    public ActionResult<List<Pet>> ListarPetsDoCliente(int clienteId)
    {
        List<Pet> petsDoCliente = DadosEmMemoria.Pets
            .Where(p => p.ClienteId == clienteId)
            .ToList();

        return Ok(petsDoCliente);
    }
}
