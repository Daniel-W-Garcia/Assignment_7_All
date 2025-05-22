/*

1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Create a parking system class with 3 slot sizes (small, medium, large)
initialize the parking lot with slots for each size
cars are also 3 sizes and can only park in the slots of the same size

ParkingSystem small spots: 1 medium spots: 1 large spots: 1
bool park car(size small) = true
bool park car(size medium) = true
bool park car(size large) = true
bool park car(size small) = false out of spots
bool park car(size medium) = false out of spots
bool park car(size large) = false out of spots

Option 1

iniitalize parking system with var for each size
decrement size for each car parked
run a while loop over all cars and return bool for each car if it is parked or not
if parking lot is full return false
return false for each slot size once they fill up

option 2

we can do a BST and have child nodes for each size
Root size would be medium
left would be small
right would be large
this seems excessive for this problem

*/

var parkingSystem = new ParkingSystem(1, 1, 1);

int smallAvailable = parkingSystem.SmallSlots;
int mediumAvailable = parkingSystem.MediumSlots;
int largeAvailable = parkingSystem.LargeSlots;

bool parkCar(Car car)
{
    if (car.Size == Car.CarSize.Small && smallAvailable > 0)
    {
        smallAvailable--;
        return true;
    }
    else if (car.Size == Car.CarSize.Medium && mediumAvailable > 0)
    {
        mediumAvailable--;
        return true;
    }
    else if (car.Size == Car.CarSize.Large && largeAvailable > 0)
    {
        largeAvailable--;
        return true;
    }
    else
    {
        return false;
    }
}



var carSmall = new Car(Car.CarSize.Small);
var carMedium = new Car(Car.CarSize.Medium);
var carLarge = new Car(Car.CarSize.Large);




string wasParked = "was parked";
string wasNotParked = "was not parked, no slots available";

Console.WriteLine();
Console.WriteLine($"The car of size '{carSmall.Size.ToString()}' {(parkCar(carSmall) ? wasParked : wasNotParked)}");
Console.WriteLine($"The car of size '{carMedium.Size.ToString()}' {(parkCar(carMedium) ? wasParked : wasNotParked)}");
Console.WriteLine($"The car of size '{carLarge.Size.ToString()}' {(parkCar(carLarge) ? wasParked : wasNotParked)}");
Console.WriteLine($"The car of size '{carSmall.Size.ToString()}' {(parkCar(carSmall) ? wasParked : wasNotParked)}");
Console.WriteLine($"The car of size '{carMedium.Size.ToString()}' {(parkCar(carMedium) ? wasParked : wasNotParked)}");
Console.WriteLine($"The car of size '{carLarge.Size.ToString()}' {(parkCar(carLarge) ? wasParked : wasNotParked)}");
Console.WriteLine();



public class ParkingSystem
{
    public int SmallSlots { get; set; }
    public int MediumSlots { get; set; }
    public int LargeSlots { get; set;}
    
    public ParkingSystem(int smallSlots, int mediumSlots, int largeSlots)
    {
        SmallSlots = smallSlots;
        MediumSlots = mediumSlots;
        LargeSlots = largeSlots;
    }
}

public class Car
{
    public enum CarSize
    {
        Small,
        Medium,
        Large
    }
    public CarSize Size { get; set; }
    public Car(CarSize size)
    {
        Size = size;
    }
}
