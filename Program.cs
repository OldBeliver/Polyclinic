using System;

namespace Polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int vanishTime = 10;
            int spendTime;
            int hoursToWait;
            int minutesToWait;
            int minutesPerHour = 60;

            Console.WriteLine("Очередь... Очередь в поликлинике никогда не заканчивается...");
            Console.WriteLine("Старушки развязали очередь, чтобы остановить время...");
            Console.WriteLine("Вы смотрите на очередь и понимаете, что встретите здесь старость...");
            Console.WriteLine("как учила Вас мама перед сном, Вы начинаете считать старушек: раз старушка, два старушка, три старушка...");
            Console.Write("сбившись три раза, Вы все-таки пересчитали старушек, их было: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            spendTime = peopleInLine * vanishTime;
            hoursToWait = spendTime / minutesPerHour;
            minutesToWait = spendTime % minutesPerHour;

            Console.WriteLine();
            Console.WriteLine($"Выйдя из транса Вы понимаете, что состаритесь в этой очереди на {hoursToWait} часа и {minutesToWait} минут.");
        }
    }
}
