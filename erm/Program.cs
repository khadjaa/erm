using System.Text.Json.Serialization;
using erm.Repositories;
using erm.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<ErmDbContext>(con =>
    con.UseSqlServer("server=localhost;integrated security=True; database=ErmDB;TrustServerCertificate=true;")
        .LogTo(Console.Write, LogLevel.Information)
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRiskService, RiskService>();
builder.Services.AddScoped<IRiskCategoryService, RiskCategoryService>();
builder.Services.AddScoped<IRiskAssessmentService, RiskAssessmentService>();
builder.Services.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ErmDbContext>();
    context.Database.Migrate();
    
    //TODO -- NoTracking
    //var bank = context.Banks.First();
    //var oldName = bank.Name;
    //context.Attach(bank);
    //bank.Name = "Test";
    ////context.Update(bank);
    //context.SaveChanges();

    //bank.Name = oldName;
    //context.SaveChanges();

    //TODO - LazyLoadingProxies
    //var bank = context.Banks.First();
    //var name = bank.Name;
    //var branchs = bank.Branchs;


    //TODO: Lazy loading for spesific properties
    //var branch = context.Branchs.First();
    //var address = branch.Address;
    //var bank = branch.Bank;
    //var bank2 = branch.Bank;
}

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