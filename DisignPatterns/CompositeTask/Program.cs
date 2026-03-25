using CompositeTask.Shapes;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Composite ===\n");

// прості фігури
IShape redCircle = new Circle("червоне");
IShape blueCircle = new Circle("синє");
IShape bigRectangle = new Rectangle(1920, 1080);

// складна фігура
CompositeShape logo = new CompositeShape("Логотип");
logo.Add(redCircle);
logo.Add(blueCircle);

// увесь малюнок
CompositeShape mainDrawing = new CompositeShape("Головне полотно");
mainDrawing.Add(bigRectangle);
mainDrawing.Add(logo); 

 
mainDrawing.Draw(1);

Console.ReadKey();