using Domain;
using Domain.Beverages;
using Domain.Condiments;

IBeverage espresso = new Espresso();
Console.WriteLine($"Beverage: {espresso.GetDescription()}, cost: {espresso.GetCost()}");

IBeverage darkRoast = new DarkRoast();

darkRoast = new Whip(new Mocha(new Mocha(darkRoast))); // <-- wrapping the component with multiple decorators

Console.WriteLine($"Beverage: {darkRoast.GetDescription()}, cost: {darkRoast.GetCost()}");