ConsoleKeyInfo key;
do
{
     Console.WriteLine("Переключение между окатвами на F5 и F4");
    key = Console.ReadKey();


    if (key.Key == ConsoleKey.F4)
    {
        Console.WriteLine("Четвертая Октава");
        fourthOcatva();
        
        

    }
    else if (key.Key == ConsoleKey.F5)
    {
        Console.WriteLine("Пятая Октава");
        FiftOcatva();
       

    }
         
} while (key.Key  != ConsoleKey.Escape);





    static void FiftOcatva()
{
    int[] Chastota = new int[] { 523, 587, 659,698,784,880,988,544,622,740,830,932 };
   
    char key = '1';
    do
    {
        key = Console.ReadKey(true).KeyChar;
        switch (key)
        {
            case 'q':
                Console.Beep(Chastota[0], 200);

                break;
            case 'w':
                Console.Beep(Chastota[1], 200);

                break;
            case 'e':
                Console.Beep(Chastota[2], 200);

                break;
            case 'r':
                Console.Beep(Chastota[3], 200);

                break;
            case 't':
                Console.Beep(Chastota[4], 200);

                break;
            case 'y':
                Console.Beep(Chastota[5], 200);

                break;
            case 'u':
                Console.Beep(Chastota[6], 200);

                break;
            case 's':
                Console.Beep(Chastota[7], 200);

                break;
            case 'd':
                Console.Beep(Chastota[8], 200);

                break;
            case 'f':
                Console.Beep(Chastota[9], 200);

                break;
            case 'g':
                Console.Beep(Chastota[10], 200);

                break;
            case 'h':
                Console.Beep(Chastota[11], 200);

                break;
            

               
        }
    } while (key != ((char)ConsoleKey.Escape));
}


static void fourthOcatva()
{
    int[] Chastota = new int[] { 261,293,329,349,392,440,493,277,311,370,415,462 };
   
    char key = '1';
    do
    {
        key = Console.ReadKey(true).KeyChar;
        switch (key)
        {
            case 'q':
                Console.Beep(Chastota[0], 200);

                break;
            case 'w':
                Console.Beep(Chastota[1], 200);

                break;
            case 'e':
                Console.Beep(Chastota[2], 200);

                break;
            case 'r':
                Console.Beep(Chastota[3], 200);

                break;
            case 't':
                Console.Beep(Chastota[4], 200);

                break;
            case 'y':
                Console.Beep(Chastota[5], 200);

                break;
            case 'u':
                Console.Beep(Chastota[6], 200);

                break;
            case 's':
                Console.Beep(Chastota[7], 200);

                break;
            case 'd':
                Console.Beep(Chastota[8], 200);

                break;
            case 'f':
                Console.Beep(Chastota[9], 200);

                break;
            case 'g':
                Console.Beep(Chastota[10], 200);

                break;
            case 'h':
                Console.Beep(Chastota[11], 200);

                break;

        }
    } while (key != ((char)ConsoleKey.Escape));
}