static void Calculate(double a, double b, double c)
{
    Console.WriteLine("Среднее арифметическое: " + ((a + b + c) / 3).ToString());
    Console.ReadKey();
}

double a, b, c;
Console.WriteLine("Hello, enter 1st value");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now enter 2nd value");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And enter 3rd value");
c = Convert.ToInt32(Console.ReadLine());

Calculate(a, b, c); 
// спец.комментарий, т.к. предудущие ветки были удалены и настроены заново из-за нового локального репозитория
