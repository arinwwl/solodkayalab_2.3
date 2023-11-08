Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {
            double a = 1.2;
            double b = 7.2; double z = Math.Exp(x);
            double y = 0; if (x < a * a * a) y = a * Math.Pow(Math.Sin(a), 2) * x + b * Math.Cos(z * x + a);
            else if (Math.Pow(a, 3) <= x && (x <= b)) y = (a + b * x) * (a + b * x) - Math.Sin(a + z * x); else if (x > b) y = Math.Sqrt(x - Math.Sin(b * x + z));
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 2:
        {
            double a = -1.5;
            double b = 3.2; double z = Math.Exp(2 * x);
            double y = 0; if (x < a * a * a) y = a * Math.Pow(Math.Sin(a), 2) * x + b * Math.Cos(z * x + a);
            else if (Math.Pow(a, 3) <= x && (x <= b)) y = (a + b * x) * (a + b * x) - Math.Sin(a + z * x); else if (x > b) y = Math.Sqrt(x - Math.Sin(b * x + z));
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 3:
        {
            double a = 1.7;
            double b = 5.5; double z = Math.Exp(3);
            double y = 0; if (x < a * a * a) y = a * Math.Pow(Math.Sin(a), 2) * x + b * Math.Cos(z * x + a);
            else if (Math.Pow(a, 3) <= x && (x <= b)) y = (a + b * x) * (a + b * x) - Math.Sin(a + z * x); else if (x > b) y = Math.Sqrt(x - Math.Sin(b * x + z));
            Console.WriteLine($"y={y:F2}");
        }
        break;
}

