namespace Adapter;
class Program
{
    static void Main()
    {
        Client client1 = new Client(5);
        Client client2 = new Client(100);
        Service service = new Service('A');
        //client.Add(service); error, incompatible types
        Adapter adapter = new(service);
        Console.WriteLine(client2.Add(client1));
        Console.WriteLine(adapter.Add(client1));
    }
}