using LH_Pets.Models;

namespace LH_Pets.Data;

// Guarda os dados da aplicação na memória.
// Por ser "static", existe uma única cópia destas listas enquanto a API estiver rodando,
// e os dois controladores usam as mesmas listas.
// Atenção: quando a aplicação é reiniciada, todos os dados são perdidos.
public static class DadosEmMemoria
{
    public static List<Cliente> Clientes { get; } = new List<Cliente>();
    public static List<Pet> Pets { get; } = new List<Pet>();

    // Contadores usados para gerar o próximo Id de cada cadastro.
    public static int ProximoClienteId { get; set; } = 1;
    public static int ProximoPetId { get; set; } = 1;
}
