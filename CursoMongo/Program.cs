using System;

namespace CursoMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static void MainSync(string[] args)
        {
            Console.WriteLine("Esperando 10 segundos.....");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Esperando 10 segubndos.....");
        }
    }
}
