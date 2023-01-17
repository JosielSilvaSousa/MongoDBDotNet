using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class ListandoDocumentos
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


           Console.WriteLine("Listando Documentos");
                                                                 //New BSONDOCUMENTO para informar que não tem criterio para busca.
            var listaLivros = await conexaoBiblioteca.Livros.Find(new BsonDocument()).ToListAsync();

            foreach(var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
        }
    }
}
