namespace LH_Pets.Models;

// Representa um animal de estimação cadastrado na LH-Pets.
public class Pet
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Especie { get; set; } = string.Empty;
    public string Raca { get; set; } = string.Empty;

    // Id do cliente responsável por este pet.
    public int ClienteId { get; set; }
}
