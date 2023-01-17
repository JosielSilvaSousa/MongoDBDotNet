using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class listandoDocumenosPorOrdem
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {


            var conexaoBiblioteca = new ConectandoMongoDB();



           Console.WriteLine("Listando Documentos mais de 100 paginas");

            var contructor = Builders<Livros>.Filter;
            var condicao = contructor.Gt(x => x.Pagina, 100);


           var  listaLivros = await conexaoBiblioteca.Livros.Find(condicao).SortBy(x => x.Titulo).Limit(5).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
            Console.WriteLine("");
            Console.WriteLine("");

          


          

        }
    }
}
