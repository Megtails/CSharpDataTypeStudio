Console.WriteLine("How many miles per gallon does your car get?");
string milesPerGallon = Console.ReadLine();
double mpg = double.Parse(milesPerGallon);

Console.WriteLine("Please enter a radius:");
string radius = Console.ReadLine();
double r = double.Parse(radius);

double area = Math.PI * (r * r);
double aRounded = Math.Round(area, 3);

double circumference = 2 * Math.PI * r;
double cRounded = Math.Round(circumference, 3);

double diameter = 2 * r;
double dRounded = Math.Round(diameter, 3);

double roundTrip = circumference / mpg;
double rT = Math.Round(roundTrip, 3);

Console.WriteLine("The area of a circle of radius " + radius + " is: " + aRounded);
Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + cRounded);
Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + dRounded);
Console.WriteLine("It would take you " + rT + " gallons of gas to travel once around this circle.");
Console.WriteLine("Yay!");