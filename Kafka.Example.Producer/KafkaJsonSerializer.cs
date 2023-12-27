using System.Text;
using System.Text.Json;
using Confluent.Kafka;

namespace Kafka.Example.Producer;

public class KafkaJsonSerializer<TMessageModel>:ISerializer<TMessageModel> where TMessageModel : class,new()
{
    public byte[] Serialize(TMessageModel data, SerializationContext context)
    {
        var json = JsonSerializer.Serialize(data);

        return Encoding.UTF8.GetBytes(json);
    }
}