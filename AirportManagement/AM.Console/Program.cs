using AM.ApplicationCore.Domain; 
Passenger  passenger = new Passenger();

passenger.FirstName = "Mariem";
passenger.LastName = "Dhaouadi";
passenger.passportNumber = "123453";
passenger.EmailAddress = "mariem@";
Console.WriteLine(passenger.FirstName);

Plane plane = new Plane()
{
    Capacity=100,ManufactureDate=DateTime.Now,PlaneId=2,PlaneType = Planetype.Airbus
};
Plane plane1 = new Plane (100, DateTime.Now,1,Planetype.Airbus);