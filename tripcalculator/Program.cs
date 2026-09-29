/* 
* Name:                Michael Oliver Merendino
* Course:              CSCI 1250, Section 001
* Assignment:          Lab 02, Trip Calculator
* Date:                september 22, 2026
* Description:         Calculates the fuel, food, and work hours behind one road trip.
*/



//part 1

using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;

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

System.Console.WriteLine("pizza cost: " + pizzacost.ToString("C"));

//part 3

System.Console.WriteLine("how many hours did you work this week? ");
int HoursWorkedToday = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("what is your hourly rate? ");
double HourlyRate = Convert.ToDouble(Console.ReadLine());

//do the math

double TaxRate = .18;

double GrossPay = HoursWorkedToday * HourlyRate;

double TaxWithheld = GrossPay * TaxRate;

double TakeHomePay = GrossPay - TaxWithheld;

//do the outputs

System.Console.WriteLine("Gross Pay: " + GrossPay.ToString("C"));

System.Console.WriteLine("Tax Withheld: " + TaxWithheld.ToString("C"));

System.Console.WriteLine("Take Home Pay: " + TakeHomePay.ToString("C"));

//======== part 4: whole trip =========

//do the math

double TripTotal = fuelcost + pizzacost;

double CostPerPerson = TripTotal / numberofpeople;

double TakeHomePayPerHour = TakeHomePay / HoursWorkedToday;

double HoursYouMustWork = CostPerPerson / TakeHomePayPerHour;

//do the output

System.Console.WriteLine("Trip Total: " + TripTotal.ToString("C"));

System.Console.WriteLine("Cost Per person: " + CostPerPerson.ToString("C"));

System.Console.WriteLine("Take Home Pay Per Hour: " + TakeHomePayPerHour.ToString("C"));

System.Console.WriteLine("Hours You Must Work: " + HoursYouMustWork.ToString("F2"));
