namespace Builder;
class Program
{
    static void Main()
    {
        ShipyardPersonell workers = new ShipyardPersonell();

        Console.WriteLine("Building a cruiser ....");
        LShipyard cruiserShipyard = new LShipyard();
        workers.BuildShip(cruiserShipyard);
        Cruiser newCruiser = cruiserShipyard.DeliverCompletedShip();
        Console.WriteLine("\r\n\r\n");

        Console.WriteLine("Building a battlecruiser ....");
        XLShipyard bcShipyard = new XLShipyard();
        workers.BuildShip(bcShipyard);
        Battlecruiser newBC = bcShipyard.DeliverCompletedShip();
    }
}