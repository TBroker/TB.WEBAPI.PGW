using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Globalization;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;
using TB.WEBAPI.PGW.APPLICATION.Services;
using TB.WEBAPI.PGW.INFRASTRUCTURE.ApiClients;
using TB.WEBAPI.PGW.INFRASTRUCTURE.Configurations;
using TB.WEBAPI.PGW.INFRASTRUCTURE.DbContexts;
using TB.WEBAPI.PGW.INFRASTRUCTURE.Repositories;

var cultureInfo = new CultureInfo("en-GB");

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

// configure strongly typed settings object
builder.Services.Configure<KBankSetting>(builder.Configuration.GetSection("ConfigKBankSetting"));
builder.Services.Configure<T2PSetting>(builder.Configuration.GetSection("ConfigT2PSetting"));

// Add services to the container.

HttpClientFactory.RegisterHttpClients(builder.Services);
builder.Services.AddScoped<IApiClientService, ApiClientService>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepositories>();
builder.Services.AddScoped<IPaymentKBankService, PaymentKBankService>();
builder.Services.AddScoped<IPaymentT2PService, PaymentT2PService>();

builder.Services.AddDbContext<PaymentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseAuthorization();

app.MapControllers();

app.Run();