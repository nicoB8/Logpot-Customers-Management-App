using AutoMapper;
using logpot.io.customers_management_app.business_logic.Restaurant;
using logpot.io.customers_management_app.Mapper_Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRestaurantBL, RestaurantBL>();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<GeneralProfiles>();
});

builder.Services.AddAutoMapper(typeof(GeneralProfiles));

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
