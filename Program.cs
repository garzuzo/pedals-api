using System.ComponentModel.Design;
using pedals_api.Repositories.EntityFramework.DbContexts;
using pedals_api.Services.CategoryService;
using pedals_api.Services.PedalService;
using pedals_api.Services.ProductService;

var builder = WebApplication.CreateBuilder(args);
var allowSpecificOrigins = "pedals-ui";

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:5251");
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<PedalsContext>(builder.Configuration.GetConnectionString("SqlServerConnection"));
builder.Services.AddScoped<IPedalService, PedalService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(allowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
