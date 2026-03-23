using ComputerFacadeTask.Facades;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Facade (Запуск ПК) ===\n");

ComputerFacade computer = new ComputerFacade();

computer.TurnOn();

Console.ReadKey();