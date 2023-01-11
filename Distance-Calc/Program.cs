// salem's distance calculator
#nullable disable

// welcome
Console.Clear();
Console.WriteLine("Distance Calculator \n");

// input
Console.Write("Enter x1 value: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y1 value: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x2 value: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y2 value: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// process
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // provided formula

// output
Console.WriteLine($"Distance between the two points is {distance}");