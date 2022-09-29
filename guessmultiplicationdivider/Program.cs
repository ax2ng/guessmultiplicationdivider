internal class Program
{
    private static void Main(string[] args)
        
    {
        static void Choice()
        {
            Console.WriteLine("Выберите программу, которую вы хотите запустить");
            Console.WriteLine(" 1 - Игра Угадай число");
            Console.WriteLine(" 2 - Таблица умножения ");
            Console.WriteLine(" 3 - Вывод делителей числа ");
            Console.WriteLine(" 4 - Выйти из меню ");
            
            
        }
        Choice();
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)

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
                int variant2 = Convert.ToInt32(Console.ReadLine());
                variant = variant2;

            }
            Console.WriteLine("Вы угадали");
            Choice();
            int choice1 = Convert.ToInt32(Console.ReadLine());
            choice1 = choice;
        }
        if (choice == 2)
            {


                Console.WriteLine("Прошу помочь разобраться со вторым заданием");



            }
            Choice();
            int choice2 = Convert.ToInt32(Console.ReadLine());
            choice2 = choice;

        if (choice == 3)
        {

            Console.WriteLine("Прошу помочь разобраться с третьем заданием");

        }
    }       
}       