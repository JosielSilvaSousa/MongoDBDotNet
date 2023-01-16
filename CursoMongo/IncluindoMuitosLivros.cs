using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CursoMongo
{
    class IncluindoMuitosLivros
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

            List<Livros> Livros = new List<Livros>();

            Console.WriteLine("Digite a quantidade de registros");
            var  _Quantidade = Console.ReadLine();


            //Forma interativa
            for (int x = 0; x < int.Parse(_Quantidade); x++) 
                {
                    Console.WriteLine("Digite o nome do Livro");
                    var nomeLivro = Console.ReadLine();

                    Console.WriteLine("Digite o nome do Autor");
                    var nomeAutor = Console.ReadLine();

                    Console.WriteLine("Digite o ano");
                    var ano = Console.ReadLine();

                    Console.WriteLine("Digite quantidade de paginas");
                    var paginas = Console.ReadLine();

                    Console.WriteLine("Digite o assunto");
                    var assunto = Console.ReadLine();

                    Livros.Add(valoresLivro.incluirValoresLivro(nomeLivro, nomeAutor, int.Parse(ano), int.Parse(paginas), assunto));
                }
            //Forma direta
            //Livros.Add(valoresLivro.incluirValoresLivro("A Dança com os Dragões", "George R R Martin", 2011, 934, "Fantasia, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("A Tormenta das Espadas", "George R R Martin", 2006, 1276, "Fantasia, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Memórias Póstumas de Brás Cubas", "Machado de Assis", 1915, 267, "Literatura Brasileira"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Star Trek Portal do Tempo", "Crispin A C", 2002, 321, "Fantasia, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Star Trek Enigmas", "Dedopolus Tim", 2006, 195, "Ficção Científica, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Emília no Pais da Gramática", "Monteiro Lobato", 1936, 230, "Infantil, Literatura Brasileira, Didático"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Chapelzinho Amarelo", "Chico Buarque", 2008, 123, "Infantil, Literatura Brasileira"));
            //Livros.Add(valoresLivro.incluirValoresLivro("20000 Léguas Submarinas", "Julio Verne", 1894, 256, "Ficção Científica, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Primeiros Passos na Matemática", "Mantin Ibanez", 2014, 190, "Didático, Infantil"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Saúde e Sabor", "Yeomans Matthew", 2012, 245, "Culinária, Didático"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Goldfinger", "Iam Fleming", 1956, 267, "Espionagem, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("Da Rússia com Amor", "Iam Fleming", 1966, 245, "Espionagem, Ação"));
            //Livros.Add(valoresLivro.incluirValoresLivro("O Senhor dos Aneis", "J R R Token", 1948, 1956, "Fantasia, Ação"));



            await conexaoBiblioteca.Livros.InsertManyAsync(Livros);

            Console.WriteLine("Documento incluido com sucesso");

        }
    }
}
