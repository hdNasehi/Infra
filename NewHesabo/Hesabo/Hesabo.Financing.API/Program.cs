using Hesabo.EventDriven.MassTransit;
using Hesabo.Financing.Infrastructure.EventBus.Consumers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.AddMassTransitWithRabbitMQ(typeof(CompanyCreatedConsumer).Assembly,"fin-");

// Optional: Swagger or other services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();