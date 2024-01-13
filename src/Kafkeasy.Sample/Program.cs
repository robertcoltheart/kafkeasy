using Confluent.Kafka;

var config = new ConsumerConfig();
config.BootstrapServers = "localhost:9092";
config.GroupId = "kafkeasy";
config.EnableAutoOffsetStore = false;
config.EnableAutoCommit = false;
config.AutoOffsetReset = AutoOffsetReset.Latest;

var consumer = new ConsumerBuilder<string, string>(config)
    .SetLogHandler((consumer1, message) => Console.WriteLine(message.Message))
    .SetErrorHandler((consumer1, error) => Console.WriteLine(error.Reason))
    .Build();

var producer = new ProducerBuilder<string, string>(config)
    .Build();

consumer.Subscribe("sample-topic");

//producer.Produce("sample-topic", new Message<string, string>
//{
//    Key = "1",
//    Value = "2"
//});

while (true)
{
    var message = consumer.Consume();

    Console.WriteLine($"{{{message.Message.Key},{message.Message.Value}}}");
}
