void Choice()
{
    Console.WriteLine("Выберите программу, которую вы хотите запустить");
    Console.WriteLine(" 1 - Игра Угадай число");
    Console.WriteLine(" 2 - Таблица умножения ");
    Console.WriteLine(" 3 - Вывод делителей числа ");
    Console.WriteLine(" 4 - Выйти из меню ");


}

void Guess()
{
    Console.WriteLine("Угадай число от 0 до 100");
    Random rnd = new Random();
    int i = rnd.Next(0, 101);
    int variant = Convert.ToInt32(Console.ReadLine());
    while (i != variant)

    {

        if (variant > i)
            Console.WriteLine("Надо меньше");
        if (variant < i)
            Console.WriteLine("Надо больше");
        variant = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine("Вы угадали");
}

void Tablica()
{
    // Я ПОНЯЛ что есть команда Write, вместо writeline

    int[,] tablica = new int[10, 10]; // new int tablica ?????????????????

    for (int ryad = 0; ryad < 10; ryad++)
    {
        for (int mesto = 0; mesto < 10; mesto++)
        {
            tablica[ryad, mesto] = (ryad+1)*(mesto+1);
        }
    }


    for (int a = 0; a < tablica.GetLength(0); a++) //  что такое getLength , у меня было < 10 
    {

        for (int b = 0; b < tablica.GetLength(1); b++) 
        {

            Console.WriteLine(tablica[a, b]);

        }
    }   
}

void Delitel()
{


    Console.WriteLine("Введите число");
    int d = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= d; i++) // int i = 0 ???????????????
    {


        if (d % i == 0)

        {
            Console.WriteLine(i);
        }


    }



}


Choice();
int choice = Convert.ToInt32(Console.ReadLine());
while (choice != 4)
{

    if (choice == 1)

    {
        Guess();

    }
    if (choice == 2)
    {

        Tablica();



        // КАК КРАСИВО ОФОРМЛЯТЬ ????????????????????????????????????????????????
    }


    if (choice == 3)
    {

        Delitel();


    }
    Choice();
    choice = Convert.ToInt32(Console.ReadLine());
}

}       
