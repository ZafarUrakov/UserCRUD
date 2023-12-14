using CalculationCRUD.Services.Foundations.Calculations;
using FeedbackCRUD.Services.Foundations.Feedbacks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserCRUD.Brokers.Storages;
using UserCRUD.Services.Foundations.Users;
using UserCRUD.Services.Orchestrations;
using UserCRUD.Services.Processings.Calculations;
using UserCRUD.Services.Processings.Feedbacks;
using UserCRUD.Services.Processings.Users;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<IStorageBroker, StorageBroker>();

AddFoundations(builder);
AddProcessings(builder);
Orchestrations(builder);

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

static void AddFoundations(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<ICalculationService, CalculationService>();
    builder.Services.AddTransient<IFeedbackService, FeedbackService>();
}

static void AddProcessings(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserProcessingService, UserProcessingService>();
    builder.Services.AddTransient<ICalculationProcessingService, CalculationProcessingService>();
    builder.Services.AddTransient<IFeedbackProcessingService, FeedbackProcessingService>();
}

static void Orchestrations(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<ICalculationOrchestrationService, CalculationOrchestrationService>();
}