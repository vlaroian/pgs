using System;


namespace primary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I'm trying to be programmer");
            Console.WriteLine("Zadej číslo 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("číslo se vynásobí číslem 2");
            a = a * 2;
            Console.WriteLine(a);

        }
    }
}
