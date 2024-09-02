namespace Prototype;
class Program
{
    static void Wait(List<ICell> dish)
    {
        Console.WriteLine("Waiting........");
        Thread.Sleep(10_000);
        int initLength = dish.Count;
        for (int i = 0; i < initLength; i++)
            dish.Add(dish[i].Clone());
    }
    static void ViewDishContents(List<ICell> dish)
    {
        int bacteria = 0, viruses = 0;
        foreach (var c in dish)
        {
            if (c.GetType() == typeof(Bacterium))
                bacteria++;
            else
                viruses++;
        }
        Console.WriteLine($"There are {bacteria} harmless bacteria and {viruses} deadly viruses");
    }
    static void Main()
    {
        List<ICell> petriDish = new List<ICell>();
        petriDish.Add(new Bacterium(3, false));
        petriDish.Add(new Bacterium(5, false));
        petriDish.Add(new Bacterium(1, false));

        petriDish.Add(new Virus(3, true));
        petriDish.Add(new Virus(4, true));
        petriDish.Add(new Virus(5, true));
        petriDish.Add(new Virus(2, true));
        petriDish.Add(new Virus(1, true));
        ViewDishContents(petriDish);
        Wait(petriDish);
        ViewDishContents(petriDish);
    }
}