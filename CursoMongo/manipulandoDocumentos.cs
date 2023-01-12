using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CursoMongo
{
    class manipulandoDocumentos
    {

        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
            //   {
            //       "Título":"Guerra dos Tronos",
            //       "Autor":"George R R Martin",
            //        "Ano":1999,
            //        "Páginas":856
            //        "Assunto": [
            //        "Fantasia",
            //        "Ação"
            //      ]
            //     }
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
;
        }
    }
}
