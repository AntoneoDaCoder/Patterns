namespace Bridge;
class Program
{
    //ICar and Driver combined implement Bridge pattern
    static void Main()
    {
        //ElectricCar eCar1 = new(30, 5);
        //Driver genericDriver = new(eCar1);
        //genericDriver.Introduce();
        //genericDriver.DriveToDestination("Washington", 200);

        //ElectricCar eCar2 = new(30, 5);
        //ExperiencedDriver expDriver = new(eCar2);
        //expDriver.Introduce();
        //expDriver.DriveToDestination("Washington", 200);

        //ElectricCar eCar3 = new(30, 5);
        //InexperiencedDriver inexpDriver = new(eCar3);
        //inexpDriver.Introduce();
        //inexpDriver.DriveToDestination("Washington", 200);

        ICCar iCCar = new(70, 10);
        ExperiencedDriver someDriver = new(iCCar);
        someDriver.Introduce();
        someDriver.DriveToDestination("LA", 500);

    }
}
