using MentoriaApi.Data;
using MentoriaApi.StartupHelper;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Sinks.LogBee;
using Serilog.Sinks.LogBee.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();
builder.Services.AddSerilog((services, lc) => lc
    .WriteTo.LogBee(new LogBeeApiKey(
            builder.Configuration["SerilogConfig:LogBee.OrganizationId"]!,
            builder.Configuration["SerilogConfig:LogBee.ApplicationId"]!,
            builder.Configuration["SerilogConfig:LogBee.ApiUrl"]!
        ),
        services
    ));

builder.Services.AddDbContext<MentoriaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Mentoria") ?? throw new InvalidOperationException("Connection string 'Mentoria' not found.")));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCustomServices();

var app = builder.Build();
app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseLogBeeMiddleware();

app.Run();
