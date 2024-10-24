using System.Net.Mail;

try
{
    Console.WriteLine("Введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вариант");
    double v = double.Parse(Console.ReadLine());
    double r;
    switch (v) {
        case 1:
            { double a = 8.7; double b = 3.7; double z = Math.Tan(b * x);
            if (x < a)
            {
                r = x * Math.Exp(x) + (z + 7 * a * b * x);
            }
            else if (a <= x && x <= b * b)
            {
                r = Math.Tan(a * x + z) + Math.Cos(b * x) * Math.Cos(b * x);
            }
            else
            {
                r = Math.Log(Math.Sin(a + b * x + x * x) * Math.Sin(a + b * x + x * x));
            }
            Console.WriteLine($"Вариант 1: y({x}) = {r}"); }
                break;
        case 2:
            {
                double a = 9.3; double b = 3.5; double z = Math.Tan(a * b * x);
                if (x < a)
                {
                    r = x * Math.Exp(x) + (z + 7 * a * b * x);
                }
                else if (a <= x && x <= b * b)
                {
                    r = Math.Tan(a * x + z) + Math.Cos(b * x) * Math.Cos(b * x);
                }
                else
                {
                    r = Math.Log(Math.Sin(a + b * x + x * x) * Math.Sin(a + b * x + x * x));
                }
                Console.WriteLine($"Вариант 2: y({x}) = {r}");
            }
            break;
        case 3:
            {
                double a = 2.1; double b = 5.7; double z = Math.Tan(b * b * x);
                if (x < a)
                {
                    r = x * Math.Exp(x) + (z + 7 * a * b * x);
                }
                else if (a <= x && x <= b * b)
                {
                    r = Math.Tan(a * x + z) + Math.Cos(b * x) * Math.Cos(b * x);
                }
                else
                {
                    r = Math.Log(Math.Sin(a + b * x + x * x) * Math.Sin(a + b * x + x * x));
                }
                Console.WriteLine($"Вариант 3: y({x}) = {r}");
            }
             break;
        default: Console.WriteLine("Неверный номер варианта.");break;

    }

}
catch
{
    Console.WriteLine("Введите корректные данные");
}