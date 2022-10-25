namespace Практическая_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            int i = rando.Next(100);
            int prob = 1;
            Console.WriteLine("Загадано число от 1 до 100, у тебя всего одна попытка;)");
            Console.WriteLine("Введите число ");
            int k = Convert.ToInt32(Console.ReadLine());
            while (prob <= 20)
            {
                if (i == k)
                {
                    Console.WriteLine("Хорошая работа, ты угадал");
                    break;
                }
                else
                {
                    prob++;
                    {
                        Console.WriteLine("К сожелению ты не смог угадать");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}