using System;
using System.ComponentModel.Design;

int a;
do
{
    Console.WriteLine("1.Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закончить программу");
    string input = Console.ReadLine();
    a = Convert.ToInt32(input);
    if (a == 1)
    {


        Random rnd = new Random();
        int b = rnd.Next(0, 100);
        int f;
        Console.WriteLine("Введите ваше число");
        do
        {


            string v = Console.ReadLine();
            f = Convert.ToInt32(v);




            if (f > b)
            {
                Console.WriteLine("Введите число поменьше");
            }
            else if (f < b)
            {
                Console.WriteLine("Введите число побольше");
            }
            else
            {
                Console.WriteLine("Вы угдали число");
            }

        } while (f != b);

    }
    if (a == 2)
    {

        int[,] myltiplytable = new int[10, 10];
        for (int i = 1; i < 10; i++)
            for (int j = 1; j < 10; j++)
                myltiplytable[i, j] = i * j;
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine();
            for (int j = 1; j < 10; j++)
                Console.Write("{0,3}", myltiplytable[i, j]);
            Console.WriteLine();
        }
    }
    if (a == 3)
    {
        Console.WriteLine("Введите число");
        string v = Console.ReadLine();
        int f = Convert.ToInt32(v);
        int i = 0;
        while (i <= f)
        {
            i++;
            if (f % i == 0)
            {

                Console.WriteLine(i);
            }


        }




    }
}







while (a <= 3);