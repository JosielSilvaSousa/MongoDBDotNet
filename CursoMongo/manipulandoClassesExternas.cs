using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class manipulandoClassesExternas
    {

        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
            // var doc = new BsonDocument {
            //     { "Titulo","Guerra dos Tronos" }
            //     };
            // doc.Add("autor", "George R R Martin");
            // doc.Add("Ano", 1990);
            //  doc.Add("Paginas", 856);

            // var assuntoArray = new BsonArray();
            // assuntoArray.Add("Fantasil");
            //  assuntoArray.Add("Ação");

            //  doc.Add("Assunto", assuntoArray);

            // Console.WriteLine(doc);

            Livros livro = new Livros();
            livro.Titulo = "Star Wars legends";
            livro.Autor = "Timothy Zahn";
            livro.Ano = 2021;
            livro.Pagina = 235;

            List<string> listaAssunto = new List<string>();
            listaAssunto.Add("Ficção Cientifica");
            listaAssunto.Add("Ação");
            livro.Assunto = listaAssunto;


            //Acesso ao servidor ao mongo DB
            string stringConexao = "mongodb://localhost:27017";
            //  IMongoClient cliente = new MongoClient(stringConexao);

            //acessando ao banco de dados.

            //   IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

            //acessando a colletion
            //   IMongoCollection<Livros> colecao = bancoDados.GetCollection<Livros>("Livros");

            //Incluindo documento

            //Acessando atravez da classe de conexaõ

            var conexaoBiblioteca = new ConectandoMongoDB();           

            await conexaoBiblioteca.Livros.InsertOneAsync(livro);

            Console.WriteLine("Documento incluido com sucesso");

        }
    }
}
