using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace N5Now.Infraestructure.Messaging
{

    public class KafkaProducer
    {
        private readonly IProducer<Null, string> _producer;

        public KafkaProducer()
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public async Task PublishAsync(string message)
        {
            await _producer.ProduceAsync("permission-topic", new Message<Null, string> { Value = message });
        }
    }

}