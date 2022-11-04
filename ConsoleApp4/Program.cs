{
    const double Pi = 3.14;
    double R, H, V, S;

    Console.WriteLine("Введите радиус цилиндра");
    R = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите высоту цилиндра");
    H = Convert.ToDouble(Console.ReadLine());

    V = Pi * Math.Pow(R, 2) * H;
    S = (Pi * Math.Pow(R, 2) * H) * 2;

    Console.WriteLine("Определяем объем цилиндра" + V.ToString());
    Console.WriteLine("Определяем площадь поверхности цилиндра" + S.ToString());
    Console.ReadKey();

}
