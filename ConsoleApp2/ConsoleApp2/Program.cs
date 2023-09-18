using System;
bool work;
work = true;
Console.WriteLine("Меню:");
Console.WriteLine("1: Сложить числа");
Console.WriteLine("2: Вычесть первое из второго");
Console.WriteLine("3: Найти произведение");
Console.WriteLine("4: Найти частное от деления");
Console.WriteLine("5: Возвести число в степень");
Console.WriteLine("6: Найти квадратный корень из числа");
Console.WriteLine("7: Найти 1 процент от числа");
Console.WriteLine("8: Найти факториал");
Console.WriteLine("9 или больше: Выйти из программы");
Console.WriteLine("Выберите действие:)");
do
{
    while (work == true)
    {
        int operation = Convert.ToInt32(Console.ReadLine());
        if (operation == 1)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = a + b;
            Console.WriteLine("ответ: " + s);
        }
        if (operation == 2)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int r = a - b;
            Console.WriteLine("ответ: " + r);
        }
        if (operation == 3)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int p = a * b;
            Console.WriteLine("ответ: " + p);
        }
        if (operation == 4)
        {
            Console.Write("Введите первое число: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float b = Convert.ToInt32(Console.ReadLine());
            if (b > 0)
            {
                float h = a / b;
                Console.WriteLine("ответ: " + h);
            }
            else if (b == 0)
            {
                Console.WriteLine("На 0 делить нельзя!!");
            }
        }
        if (operation == 5)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double q = Math.Pow(a, b);
            Console.WriteLine("ответ: " + q);
        }
        if (operation == 6)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double k = Math.Sqrt(a);
            Console.WriteLine("ответ: " + k);
        }
        if (operation == 7)
        {
            Console.Write("Введите число: ");
            double a = (float)Convert.ToDouble(Console.ReadLine());
            double t = a / 100;
            Console.WriteLine("ответ = " + t);
        }
        if (operation == 8)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 2; i <= a; i++)
            {
                f = f * i;
                if (i == a)
                {
                    Console.WriteLine("ответ: " + f);
                }
            }
        }
        if (operation >= 9 | operation == 0) 
        {
            break;
        }
    }
}
while (work == false);

