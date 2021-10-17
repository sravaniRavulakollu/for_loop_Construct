using System;

namespace For_Loop__Construct
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();

            Console.Write("How many times you want to display your name");
            int Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
