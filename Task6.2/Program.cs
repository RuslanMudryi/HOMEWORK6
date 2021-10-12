using System;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods_machine Machine = new Methods_machine();
            Machine.add_data();
            foreach(var ips in Machine.Ip_book )
                Console.WriteLine(ips);
            Console.WriteLine(Machine.most_popular_day());

        }
    }
}
