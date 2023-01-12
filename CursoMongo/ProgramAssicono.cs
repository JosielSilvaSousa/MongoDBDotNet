using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMongo
{
    class ProgramAssicono
    {

            static void Main(string[] args)
            {
                Task T = MainASync(args);
                Console.WriteLine("Pressione Enter");
                Console.ReadLine();
            }

            static async Task MainASync(string[] args)
            {
                Console.WriteLine("Esperando 10 segundos.....");
                await Task.Delay(10000);
                Console.WriteLine("Esperando 10 segubndos.....");
            }

    }
}
