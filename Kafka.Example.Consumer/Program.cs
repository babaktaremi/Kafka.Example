using Confluent.Kafka;
using Kafka.Example.Consumer.ConsumerWorkers;
using Kafka.Example.Consumer.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(typeof(IKafkaConsumerService<,,>), typeof(KafkaConsumerService<,,>));
builder.Services.Configure<ConsumerConfig>(config =>
{
    config.ClientId = "Kafka-test-consumer";
    config.BootstrapServers = "localhost:9092";
    config.GroupId = "Kafka-test-consumer-group";
});
builder.Services.AddHostedService<OrderModelConsumerWorker>();
builder.Services.AddHostedService<UserLoggedInConsumerWorker>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{

});


app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
