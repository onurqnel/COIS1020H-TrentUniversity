public static class VehicleDemo
{
    public static void Main()
    {
        int numDs,
            maxSpeed;
        int vehicleID;
        string carType;

        Console.Clear();
        Car richRide = new Car();
        Boat speedBoat = new Boat(54321, 30, 8, "Outboard Marine");
        Plane speedPlane = new Plane(21245, 400, 2, "Boeing");

        do
        {
            Console.Write("Enter a 5-digit vehicle identification number => ");
            vehicleID = Convert.ToInt32(Console.ReadLine());
        } while ((vehicleID < 10000) || (vehicleID > 99999));
        richRide.VIN = vehicleID;

        Console.Write("Enter the make of the car => ");
        carType = Console.ReadLine();
        richRide.Make = carType;

        do
        {
            Console.Write("Enter the number of doors for the car => ");
            numDs = Convert.ToInt32(Console.ReadLine());
        } while (numDs <= 0);
        richRide.NumDoors = numDs;

        do
        {
            Console.Write("Enter the top speed of the car => ");
            maxSpeed = Convert.ToInt32(Console.ReadLine());
        } while (maxSpeed <= 0);
        richRide.TopSpeed = maxSpeed;

        Console.WriteLine(richRide);
        Console.WriteLine("The car goes " + richRide.SoundHorn());
        Console.WriteLine(richRide.Operate());
        Console.WriteLine(speedBoat);
        Console.WriteLine("The boat goes " + speedBoat.SoundHorn());
        Console.WriteLine(speedBoat.Operate());
        Console.WriteLine(speedPlane);
        Console.WriteLine("The boat goes " + speedPlane.SoundHorn());
        Console.WriteLine(speedPlane.Operate());
    }
}
