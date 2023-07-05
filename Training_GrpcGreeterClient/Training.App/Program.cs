using Grpc.Net.Client;
using Training.App;

using var channel = GrpcChannel.ForAddress("https://localhost:7036");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Fran Fran Test" });
Console.WriteLine("Greeting: " + reply.Message);