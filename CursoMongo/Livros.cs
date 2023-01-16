using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CursoMongo
{
    public class Livros
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Pagina { get; set; }
        public List<string> Assunto { get; set; }
    }

    public class valoresLivro
    {
        public static Livros incluirValoresLivro(string Titulo, string Autor, int Ano, int Paginas, string Assuntos)
        {
            Livros livro = new Livros();
            livro.Titulo = Titulo;
            livro.Autor = Autor;
            livro.Ano = Ano;
            livro.Pagina = Paginas;
            string[] vetAssunto = Assuntos.Split(',');
            List<string> vetAssunto2 = new List<string>();
            for (int i = 0; i <= vetAssunto.Length - 1; i++)
            {
                vetAssunto2.Add(vetAssunto[i].Trim());
            }
            livro.Assunto = vetAssunto2;
            return livro;

        }
    }
}
