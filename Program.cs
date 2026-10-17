var builder = WebApplication.CreateBuilder(args);

// Registra os serviços usados pela aplicação.
builder.Services.AddControllers();          // habilita o uso de Controllers
builder.Services.AddEndpointsApiExplorer(); // permite que o Swagger descubra os endpoints
builder.Services.AddSwaggerGen();           // gera a documentação do Swagger

var app = builder.Build();

// O Swagger fica disponível apenas no ambiente de desenvolvimento.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // gera o arquivo swagger.json
    app.UseSwaggerUI(); // gera a página de testes em /swagger
}

// Liga as rotas definidas nos Controllers (ex.: /api/clientes).
app.MapControllers();

app.Run();
