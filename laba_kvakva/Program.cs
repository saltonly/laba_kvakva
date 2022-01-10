using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int rez = 0;
        char c;

        Console.WriteLine("Введите первое и второе число, или выберите операцию: +, -, *, /");
        c = Convert.ToChar(Console.ReadLine());
        switch (c)
        {
            case 'a':
                Console.WriteLine("Введите первое число");
                a = Convert.ToInt32(Console.ReadLine()); break;
        }
        Console.Write(rez);
        Console.ReadKey();
    }


}
