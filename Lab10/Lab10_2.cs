public abstract class Vehicle
{
    protected int vin;
    protected int topSpeed;

    public Vehicle(int idNum, int speed)
    {
        VIN = idNum;
        TopSpeed = speed;
    }

    public int VIN
    {
        set
        {
            if (value >= 10000 && value <= 100000)
                vin = value;
            else
                vin = 0;
        }
        get { return vin; }
    }
    public int TopSpeed
    {
        set
        {
            if (value >= 0)
                topSpeed = value;
            else
                topSpeed = 0;
        }
        get { return topSpeed; }
    }

    public virtual string SoundHorn()
    {
        return "Beeeeeeeeep";
    }

    public abstract string Operate();
}

public class Car : Vehicle
{
    private int numDoors;
    private string make;

    public Car()
        : base(0, 0)
    {
        numDoors = 0;
        make = " ";
    }

    public Car(int vid, int maxSp, int numD, string typeCar)
        : base(vid, maxSp)
    {
        numDoors = numD;
        make = typeCar;
    }

    public int NumDoors
    {
        set
        {
            if (value >= 0)
                numDoors = value;
            else
                numDoors = 0;
        }
        get { return numDoors; }
    }
    public string Make
    {
        set { make = value; }
        get { return make; }
    }

    public override string ToString()
    {
        string output;
        output = "\nThis vehicle is a car\n";
        output += "VIN: " + vin + "\n";
        output += "Make: " + make + "\n";
        output += "Number of Doors: " + numDoors + "\n";
        output += "Top Speed:" + topSpeed + " kph";
        return output;
    }

    public override string SoundHorn()
    {
        return "Hoooooooonk";
    }

    public override string Operate()
    {
        return "It drives on the road";
    }
}

public class Boat : Vehicle
{
    private int numSeats;
    private string motorType;

    public Boat(int vid, int maxSp, int numS, string mType)
        : base(vid, maxSp)
    {
        numSeats = numS;
        motorType = mType;
    }

    public override string ToString()
    {
        string output;
        output = "\nThis vehicle is a boat\n";
        output += "VIN: " + vin + "\n";
        output += "Type of motor: " + motorType + "\n";
        output += "Number of Seats: " + numSeats + "\n";
        output += "Top Speed:" + topSpeed + " knots";
        return output;
    }

    public override string Operate()
    {
        return "It moves through the water";
    }
}

public class Plane : Vehicle
{
    int numEngines;
    string planeMaker;

    public Plane(int vid, int maxSp, int numE, string pMake)
        : base(vid, maxSp)
    {
        numEngines = numE;
        planeMaker = pMake;
    }

    public override string ToString()
    {
        string output;
        output = "\nThis vehicle is a plane\n";
        output += "VIN: " + vin + "\n";
        output += "Plane Make: " + planeMaker + "\n";
        output += "Number of engines: " + numEngines + "\n";
        output += "Top Speed:" + topSpeed + " kph";
        return output;
    }

    public override string SoundHorn()
    {
        return "Whoooooosh";
    }

    public override string Operate()
    {
        return "It flies through the air";
    }
}
