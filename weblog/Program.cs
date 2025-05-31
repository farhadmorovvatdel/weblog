using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Weblog.Infrastructure.Context;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
});
builder.Services.AddIdentity<IdentityUser,IdentityRole>(
    c =>
    {
        c.Password.RequiredLength = 6;
        c.Password.RequireUppercase = false;
        c.Password.RequireLowercase=false;
       
    }
    
    ).AddEntityFrameworkStores<AppDbContext>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
