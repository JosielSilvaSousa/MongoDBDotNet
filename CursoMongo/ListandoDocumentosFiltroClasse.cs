using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class ListandoDocumentosFiltroClasse
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



            Console.WriteLine("Listando Documentos Autor = Machado de Assis");

            var filtro = new BsonDocument()
             {
                 {"Autor","Machado de Assis" }
             };

            var listaLivros = await conexaoBiblioteca.Livros.Find(filtro).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Listando Documentos Autor = Machado de Assis - Classe");

            var contructor = Builders<Livros>.Filter;
            var condicao = contructor.Eq(x => x.Autor, "Machado de Assis");


            listaLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
            Console.WriteLine("");
            Console.WriteLine("");

            /////
            Console.WriteLine("Listando Documentos anp publicade seja maior ou igual a 1999");

             contructor = Builders<Livros>.Filter;
             condicao = contructor.Gte(x => x.Ano,1999);


            listaLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
            Console.WriteLine("");
            Console.WriteLine("");

          /////
            Console.WriteLine("Listando Documentos ano publicado a partir de 1999 e que tenham mais de 300 paginas");

            contructor = Builders<Livros>.Filter;
            condicao = contructor.Gte(x => x.Ano, 1999) & contructor.Gte(x => x.Pagina, 300);


            listaLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livros>());
            }

            Console.WriteLine("Fim da lista");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Listando Documentos somente de ficção cientefica");

            contructor = Builders<Livros>.Filter;
            
            condicao = contructor.AnyEq(x => x.Assunto, "Ficção Científica");
            

            listaLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

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
