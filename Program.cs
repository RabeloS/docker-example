using docker.api.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var host = builder.Configuration["DBHOST"] ?? "localhost";
//var connection = $"Server={host};port=3306;DataBase=db_banco;Uid=root;Pwd=123456";


var connection = builder.Configuration.GetConnectionString("app_web");
builder.Services.AddDbContext<ContextDocker>(ctx => ctx.UseMySql(connection, ServerVersion.AutoDetect(connection)));
builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
