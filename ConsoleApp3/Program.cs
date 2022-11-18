

{
    const double Pi = 3.14;
    double R, S;
    Console.WriteLine("Введите радиус круга");
    R = Convert.ToDouble(Console.ReadLine());
    S = Pi * Math.Pow(R, 2);
    Console.WriteLine ("Определяем площадь круга"  + S.ToString());
    Console.ReadKey();
}

