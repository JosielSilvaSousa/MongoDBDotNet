using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class UsandoValoresLivros
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

            Livros Livro = new Livros();
            Livro = valoresLivro.incluirValoresLivro("Dom Casmurro", "Machado de Assis", 1923, 188, "omance,Literatura Brasileira");

            await conexaoBiblioteca.Livros.InsertOneAsync(Livro);

            Livros Livro2 = new Livros();
            Livro2 = valoresLivro.incluirValoresLivro("A Arte da Ficçaõ", "David Lodge", 2002, 230, "Didático, Auto Ajuda");

            await conexaoBiblioteca.Livros.InsertOneAsync(Livro2);

            Console.WriteLine("Documento incluido com sucesso");

        }

    }
}
