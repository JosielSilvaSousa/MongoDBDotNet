using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class AcessandoMongoDB
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
            var doc = new BsonDocument {
                { "Titulo","Guerra dos Tronos" }
         };
            doc.Add("autor", "George R R Martin");
            doc.Add("Ano", 1990);
            doc.Add("Paginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasil");
            assuntoArray.Add("Ação");

            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);
            //Acesso ao servidor ao mongo DB
            string stringConexao = "mongodb://localhost:27017";
            IMongoClient cliente = new MongoClient(stringConexao);

            //acessando ao banco de dados.

            IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

            //acessando a colletion
            IMongoCollection<BsonDocument> colecao = bancoDados.GetCollection<BsonDocument>("Livros");

            //Incluindo documento

            await colecao.InsertOneAsync(doc);

            Console.WriteLine("Documento incluido com sucesso");

        }
    }
}
