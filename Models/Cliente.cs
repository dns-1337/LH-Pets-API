namespace LH_Pets.Models;

// Representa um cliente da LH-Pets (o dono do pet).
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
