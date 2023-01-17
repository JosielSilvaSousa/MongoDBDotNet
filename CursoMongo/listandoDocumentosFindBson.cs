using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class listandoDocumentosFindBson
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

            var filtro = new BsonDocument();
            var listaLivros = await conexaoBiblioteca.Livros.Find(filtro).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");


            Console.WriteLine("Listando Documentos Autor = Machado de Assis");


            filtro = new BsonDocument()
             {
                 {"Autor","Machado de Assis" }
             };
            
             listaLivros = await conexaoBiblioteca.Livros.Find(filtro).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
        }
    }
}
