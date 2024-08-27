namespace Abstract_Factory;
class Program
{
    static Random Rng = new Random();
    static void Main()
    {
        while (true)
        {
            CarShowroom showroom;
            switch (Rng.Next(0, 3))
            {
                case 0:
                    showroom = new(new ECarFactory());
                    break;
                case 1:
                    showroom = new(new ICCarFactory());
                    break;
                case 2:
                    showroom = new(new HCarFactory());
                    break;
                default:
                    showroom = new(new ICCarFactory());
                    break;
            }
            showroom.TestCars();
            Thread.Sleep(2_000);
            Console.Clear();
        }
    }
}
