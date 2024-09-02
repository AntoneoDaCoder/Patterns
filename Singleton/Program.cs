using System.Xml;

namespace Singleton;
class Program
{
    static void Main()
    {
        Database db1 = Database.GetInstance();
        Console.WriteLine(db1.Num);
        db1.Num = 6;
        Database db2 = Database.GetInstance();
        Console.WriteLine(db2.Num);
    }
}