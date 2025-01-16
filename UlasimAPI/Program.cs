using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using UlasimAPI.Data;
using UlasimAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Veritabanı bağlantılarını yapılandırma
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

// Swagger API belgeleri oluşturma
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Türkiye Haritası API",
        Version = "v1",
        Description = "Türkiye haritası ile ilgili şehirler, ulaşım çözümleri API'si"
    });
});

// CORS (Cross-Origin Resource Sharing) yapılandırması
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(); // CORS'u aktif hale getiriyoruz
app.UseAuthorization();

app.MapControllers(); // Controller'ları haritalandır

app.Run();
