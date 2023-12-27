using Bogus;
using Confluent.Kafka;
using Kafka.Example.Producer;
using Kafka.Example.Producer.Models;
using Kafka.Example.Producer.Protos;
using Kafka.Example.Producer.Services;
using Timestamp = Google.Protobuf.WellKnownTypes.Timestamp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ProducerConfig>(config =>
{
    config.ClientId = "Kafka-test-producer";
    config.BootstrapServers = "localhost:9092";
});

builder.Services.AddSingleton(typeof(IKafkaProducerService<,,>), typeof(KafkaProducerService<,,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/OrderSubmitter", async (IKafkaProducerService<Null
    , OrderModel
    , KafkaJsonSerializer<OrderModel>> service) =>
{
    var fakeOrders = new Faker<OrderModel>()
        .RuleFor(c=>c.OrderId,Guid.NewGuid)
        .RuleFor(c => c.OrderName, f => f.Commerce.Product())
        .Generate(10000);

    foreach (var orderModel in fakeOrders)
    {
        await service.ProduceAsync("order-fake-topic", new Message<Null, OrderModel>() { Value = orderModel });
    }
});

app.MapPost("/UserLoggedIn", async (IKafkaProducerService<Null
    , PersonLoggedIn
    , KafkaProtoBufSerializer<PersonLoggedIn>> service) =>
{

    var fakeLogins = new Faker<PersonLoggedIn>()
        .RuleFor(c => c.UserName,f=>f.Person.UserName)
        .RuleFor(c => c.LoggedInDate, f => Timestamp.FromDateTime(f.Date.Future(1,DateTime.UtcNow)))
        .Generate(1000);

    foreach (var fakeLogin in fakeLogins)
    {
        await service.ProduceAsync("logins-fake-topic", new Message<Null, PersonLoggedIn>() { Value = fakeLogin });
    }
});


app.Run();

