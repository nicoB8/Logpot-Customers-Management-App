using AutoMapper;
using logpot.io.customers_management.repositories;
using logpot.io.customers_management.repositories.RestaurantRepository;
using logpot.io.customers_management_app.business_logic.Restaurant;
using logpot.io.customers_management_app.Mapper_Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDBContext>(x => x.UseSqlServer(connectionString, b => b.MigrationsAssembly("logpot.io.customers-management-app")), ServiceLifetime.Singleton);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRestaurantBL, RestaurantBL>();
builder.Services.AddSingleton<IRestaurantRepository, RestaurantRepository>();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<GeneralProfiles>();
});

builder.Services.AddAutoMapper(typeof(GeneralProfiles));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDBContext>();
    db.Database.Migrate();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
