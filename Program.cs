using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            string gymnasie = Console.ReadLine().ToLower();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasie == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }

            Console.ReadKey();
        }
    }
}