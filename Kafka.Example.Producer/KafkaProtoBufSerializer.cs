using Confluent.Kafka;
using Google.Protobuf;

namespace Kafka.Example.Producer;

public class KafkaProtoBufSerializer<TMessageModel>:ISerializer<TMessageModel> where TMessageModel : IMessage<TMessageModel>, new()
{
    public byte[] Serialize(TMessageModel data, SerializationContext context)
    {
        return data.ToByteArray();
    }
}