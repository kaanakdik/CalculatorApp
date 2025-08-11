using CalculatorApp;

var calc = new Calculator();

Console.Write("Birinci sayıyı girin: ");
double x = double.Parse(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
double y = double.Parse(Console.ReadLine());

Console.Write("Üçüncü sayıyı girin: ");
double z = double.Parse(Console.ReadLine());

Console.WriteLine($"Toplama: {calc.Add(x, y, z)}");
Console.WriteLine($"Çıkarma: {calc.Subtract(x, y)}");
Console.WriteLine($"Çarpma: {calc.Multiply(x, y)}");
Console.WriteLine($"Bölme: {calc.Divide(x, y)}");
