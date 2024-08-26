namespace Fabric;
class Program
{
    static Random Rng = new Random();
    static void Main()
    {
        while(true)
        {
            LogisticsCompany company = new(Rng.Next(0, 4));
            company.DeliverPackage();
            Thread.Sleep(1_500);
            Console.Clear();
        }
    }
}
