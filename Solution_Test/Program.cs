using Solution_Test.Abstractions;
using Solution_Test.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddTransient<IStadiumParkingService, StadiumParkingService>(); 
builder.Services.AddTransient<IAirportParkingService , AirportParkingService>(); 
builder.Services.AddTransient<IMallParkingService , MallParkingService>(); 
builder.Services.AddTransient<ISmallMotorcycleParkingService, SmallMotorcycleParkingService>(); 


//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "A ParkingLot Api Doc",
        Version = "v3",
        Description = "A ParkingLot Api, it generates tickets and receipts for parked and unparked vehicles.",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Emmanuel Ekpenyong",
            Email = "nueledem31@gmail.com",
            Url = new Uri("https://github.com/nueled")
        }
    });

});  // The swagger api info is set here.

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
