class Program
{
    static void Main(string[] args)
    {
        Console.Write("1е число");
        string operanD1 = Console.ReadLine();
        int operand1 = Int32.Parse(operanD1);
        Console.Write("2е число");
        string operanD2 = Console.ReadLine();
        int operand2 = Int32.Parse(operanD2);
        Console.Write("Введiть знак арифметичної операцiї");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "+":
                {
                    Console.WriteLine(operand1 + operand2);
                    break;
                }

            case "-":
                {
                    Console.WriteLine(operand1 - operand2);
                    break;
                }

            case "*":
                {
                    Console.WriteLine(operand1 * operand2);
                    break;
                }

            case "/":
                {
                    try
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    catch (DivideByZeroException)
                    { Console.WriteLine("Помилка! Операція неможлива. Заборонено ділити на нуль"); }
                    break;
                }

        }
        Console.ReadKey();

    }


}