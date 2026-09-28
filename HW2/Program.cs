using HW2;

DateTime date = DateTime.Now;
int currentYear = date.Year;
Car car = new();
car.Brand = "tesla";
car.Model = "model 3";
car.Year = 2022;
car.Speed = 200;
car.color = "red";
int carAge = currentYear - car.Year;
car.getCarInfo();
Console.WriteLine($"Car age: {carAge} years");