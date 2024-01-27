using erm.Repositories;
using erm.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IRiskService, RiskService>();
builder.Services.AddSingleton<IRiskCategoryService, RiskCategoryService>();
builder.Services.AddSingleton<IRiskAssessmentService, RiskAssessmentService>();
builder.Services.AddSingleton(typeof(IMemoryRepository<>), typeof(MemoryRepository<>));
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