// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
        {
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num < 6)
            {
                Console.WriteLine("нет");
            }
            else
            {
                Console.WriteLine("да");
            }

            Console.ReadKey(true);
        }
    }
