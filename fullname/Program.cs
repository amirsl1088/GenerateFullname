using fullname;

Console.WriteLine("enter first name");
var firstName = Console.ReadLine()!;
Console.WriteLine("enter last name");
var lastName = Console.ReadLine()!;
var p1 = new Person();
var fullName = p1.GetFullName(firstName, lastName);
Console.WriteLine($"fullname:{fullName}");