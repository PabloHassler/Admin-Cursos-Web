using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
using TRABAJO_02.Aplicacion.UseCases;
using TRABAJO_02.Repositorios;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<AltaEstudianteUseCase>();
builder.Services.AddTransient<AltaCursoUseCase>();
builder.Services.AddTransient<AltaInscripcionUseCase>();
builder.Services.AddTransient<BajaEstudianteUseCase>();
builder.Services.AddTransient<BajaCursoUseCase>();
builder.Services.AddTransient<BajaInscripcionUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<getEstudianteUseCase>();
builder.Services.AddTransient<getCursoUseCase>();
builder.Services.AddTransient<getInscripcionUseCase>();
builder.Services.AddTransient<ListaDeCursosUseCase>();
builder.Services.AddTransient<ListaDeEstudiantesUseCase>();
builder.Services.AddTransient<ListaDeInscripcionesUseCase>();
builder.Services.AddTransient<ListarCursosPorEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesPorCursoUseCase>();
builder.Services.AddTransient<ListarEstudiantesInicioUseCase>();
builder.Services.AddTransient<ListarEstudiantesFinalUseCase>();
builder.Services.AddTransient<VerificarDatosUseCase>();
builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();
builder.Services.AddScoped<IRepositorioCurso, RepositorioCurso>();
builder.Services.AddScoped<IRepositorioInscripcion, RepositorioInscripcion>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
