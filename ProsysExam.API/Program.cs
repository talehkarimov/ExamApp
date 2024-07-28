using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProsysExam.API.Data;
using ProsysExam.API.Extensions;
using ProsysExam.API.Models;
using ProsysExam.API.Repositories;
using ProsysExam.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Exam App API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Exam App API V1");
    });
}

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
