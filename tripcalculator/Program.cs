//part 1

using System.Runtime.CompilerServices;

Console.Write("what was the round trip in miles? ");
int milesforthetrip = Convert.ToInt32(Console.ReadLine());

Console.Write("what is the miles per gallon of the car you are using? ");
int milespergallon = Convert.ToInt32(Console.ReadLine());

Console.Write("what was the gas price? ");
double gasprice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsneeded = milesforthetrip / (double)milespergallon;

double fuelcost = gallonsneeded * gasprice;

//do the output
System.Console.WriteLine("gallons needed: " + gallonsneeded.ToString("F2"));
System.Console.WriteLine("fuel cost: " + fuelcost.ToString("C"));


//part2

System.Console.WriteLine("how any people are going? ");
int numberofpeople = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("how any pizzas? ");
int numberofpizzas = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("price per pizza? ");
double priceperpizza = Convert.ToDouble(Console.ReadLine());

//do the math
int slicesperpizza = 8;

double totalslices = numberofpizzas * slicesperpizza;

double slicesperperson = totalslices / numberofpeople;

double pizzacost = numberofpizzas * priceperpizza;

//do the output
System.Console.WriteLine("total slices: " + totalslices);

System.Console.WriteLine("slices per person: " + slicesperperson);

System.Console.WriteLine("pizza cost: " + pizzacost);