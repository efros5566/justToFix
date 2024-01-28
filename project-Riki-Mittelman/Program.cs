using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Data;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IProductsService,ProductsService>();
builder.Services.AddScoped<IProductsForRecepiesService, ProductsForRecepiesService>();
builder.Services.AddScoped<IRecepiesService, RecepiesService>();
builder.Services.AddScoped<IRecepiesRepository, RecepiesRepository>();
builder.Services.AddScoped<IProductsRepository, ProductRepository>();
builder.Services.AddScoped<IProductsForRecepiesRepository, ProductsForRecepiesRepository>();

//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
