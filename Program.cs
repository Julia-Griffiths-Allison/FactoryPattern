using Factory_Pattern;

Console.WriteLine("Do you want two or four wheels?");
string answer = Console.ReadLine();
var vehicle = VehicleFactory.GetVehicle(answer);
vehicle.Drive();


#region

//Create an Interface named IVehicle that has a stubbed out public void Drive method.

//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig

//Note: These classes must conform to IVehicle and implement the Drive() method- which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.

//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter

//Call this functionality in the Main method.
#endregion