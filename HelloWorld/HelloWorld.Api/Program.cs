using HelloWorld.Api.Areas.Identity.Data;
using HelloWorld.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("HelloWorldApiContextConnection") ?? throw new InvalidOperationException("Connection string 'HelloWorldApiContextConnection' not found.");

builder.Services.AddDbContext<HelloWorldApiContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<HelloWorldApiUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<HelloWorldApiContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllers();

app.Run();
