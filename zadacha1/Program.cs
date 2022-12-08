// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
    {
        int num = Convert.ToInt32(Console.ReadLine());
        num= num /= 10;
        num %= 10;
        Console.WriteLine(num);
    }
}
