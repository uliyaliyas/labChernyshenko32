Console.WriteLine("Введите широту (F):");
double F = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите долготу (D):");
double D = double.Parse(Console.ReadLine()!);

if (F >= 0)
{
    Console.WriteLine("Точка находится в северном полушарии.");
}
else
{
    Console.WriteLine("Точка находится в южном полушарии.");
}

if (D >= 0)
{
    Console.WriteLine("Точка находится в восточном полушарии.");
}
else
{
    Console.WriteLine("Точка находится в западном полушарии.");
}