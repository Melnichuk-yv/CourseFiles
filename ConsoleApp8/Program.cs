
Console.WriteLine("Будь ласка, введіть число від 0 до 100");
string sign = Console.ReadLine();
int mySign=Convert.ToInt32(sign);

if ((mySign >= 0) & (mySign <= 14))
    Console.WriteLine("Це число належить до проміжку 0-14");

else if ((mySign >= 15) & (mySign <= 35))
    Console.WriteLine("Це число належить до проміжку 15-35");

else if ((mySign >= 36) & (mySign <= 50))
    Console.WriteLine("Це число належить до проміжку 36-50");

else if ((mySign >= 51) & (mySign <= 100))
    Console.WriteLine("Це число належить до проміжку 51-100");

else Console.WriteLine("Число, яке ви ввели не належить до діапазону 0-100");

Console.ReadKey();
