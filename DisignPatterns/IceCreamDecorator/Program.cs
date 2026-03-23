using IceCreamDecoratorTask.Components;
using IceCreamDecoratorTask.Decorators;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Decorator (Кастомне морозиво) ===\n");

// звичайне ванільне морозиво
IceCream myDessert = new VanillaIceCream();
Console.WriteLine($"1. Базове: {myDessert.GetDescription()} | Вартість: {myDessert.GetCost()} грн");

// шоколадний сироп
myDessert = new ChocolateSyrup(myDessert);
Console.WriteLine($"2. Додали сироп: {myDessert.GetDescription()} | Вартість: {myDessert.GetCost()} грн");

//  горішки
myDessert = new Nuts(myDessert);
Console.WriteLine($"3. Додали горішки: {myDessert.GetDescription()} | Вартість: {myDessert.GetCost()} грн");

// ягоди
myDessert = new FruitBerries(myDessert);
Console.WriteLine($"\n--- Фінальне замовлення ---");
Console.WriteLine($"Склад: {myDessert.GetDescription()}");
Console.WriteLine($"Загальна вартість: {myDessert.GetCost()} грн");

Console.ReadKey();