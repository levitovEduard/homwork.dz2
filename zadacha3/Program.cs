// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        {
            int num = Convert.ToInt32(Console.ReadLine());
                num /= 100;
            if (num == 0)
        {
            Console.WriteLine("Третьей цифры нет");
        }
            else
            {
                num %= 10;
                Console.WriteLine(num);
            }

            Console.ReadKey(true);
        }