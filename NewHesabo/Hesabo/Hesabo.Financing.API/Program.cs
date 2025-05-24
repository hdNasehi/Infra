using Hesabo.Financing.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddConfiguredControllers();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddConfiguredSwagger();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();