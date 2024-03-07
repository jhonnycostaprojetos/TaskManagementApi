using Microsoft.OpenApi.Models;
using TaskManagement.Api.Services;
using TaskManagement.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddInfrastructure(builder.Configuration);

builder.WebHost.UseUrls("http://*:80");

builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new OpenApiInfo
       {
           Version = "v1",
           Title = "TaskManagementAPI",
           Description = "API desenvolvida para o teste técnico ECPLISEWORKS ",
           Contact = new OpenApiContact
           {
               Name = "Jhonny Costa",
               Email = "jhonnydscosta@mail.com",
               Url = new Uri("https://www.linkedin.com/in/jhonny-costa/")
           }
       });
   });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

DatabaseManagementService.MigrationInitialisation(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
