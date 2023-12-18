using EspnApi.Domain.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const int leagueId = 324746;
const string swid = "{C807AE6E-DA5E-4263-87AE-6EDA5E5263D3}";
const string espnS2 = "AEBETYgH5ZK1fsO3xF9iH2GPiV7D%2BPzjcLrv%2F%2FJCBw2avLHhUEd04AA6xu9jn7M6IDr%2By8DwWkQjdpwiJEJlJPxyLl5UetHSUDlvIHp0hbJVU3SdCrNaSHW4Up1FS6m0NrBrE4glOh6hEmQMKAjU5ExhXBQ1n%2Bhz6RHqBfm0KzOBWsu032NgbjHf9D5%2FaulrJmHbqOOzErwN2hR4Uh47UoAG2aLT2A9lkOgvy9GLZoVYNzqmtU64eXbYqr0AbyjeJ7E1kISpJ4h7KWZCqnHDmnHQaIWKRndj35ns6zwKQLBQXeA5GFHSTlOnRcBKWFqxURMf%2FMoq80ETpil8yXyr58uo";



builder.Services.AddScoped<IEspnApiService, EspnApiService>(
    _ => new EspnApiService(leagueId, swid, espnS2));

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
