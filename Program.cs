using System.Text.Json;
//Escrever um programa que faça uam requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

// using (HttpClient client = new HttpClient())
// {
//     string Resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//     System.Console.WriteLine(Resposta);
// }

//Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

// try
// {
//     System.Console.WriteLine("Digite um valor: ");
//     int a = int.Parse(Console.ReadLine()!);
//     System.Console.WriteLine("Digite outro valor: ");
//     int b = int.Parse(Console.ReadLine()!);

//     int resposta = a/b;
//     System.Console.WriteLine($"O valor é: {resposta}");
// }
// catch(DivideByZeroException ex)
// {
//     Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.{ex.Message}");
// }

//Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

// try
// {
//     List<int> numeros = new List<int>{2, 3, 4};
//     System.Console.WriteLine($"O décimo elemento é: {numeros[9]}");
// }
// catch(ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine("O elemento não esta presente na lista");
//     System.Console.WriteLine($"Erro: {ex.Message}");
// }

//Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

// try
// {
//     MinhaClasse objetoNulo = null;
//     objetoNulo.Meumetodo();
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine($"Erro: {ex.Message}");
// }

// internal class MinhaClasse
// {
//     internal void Meumetodo()
//     {
//         Console.WriteLine("A");
//     }
// }

//Modelar e desserializar a classe Filme, que pode ser encontrada no endpoint disponibilizado
//https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json

// using System.Text.Json;

// try
// {
//     using(HttpClient client = new HttpClient())
//     {
//         string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//         var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
//         foreach (var filme in filmes)
//         {
//             Console.WriteLine(filme.ShowDetails);
//         }
//     }
// }
// catch(Exception ex)
// {
//     System.Console.WriteLine($"Erro: {ex.Message}");
// }

//Modelar e desserializar a classe Pais, que pode ser encontrada no endpoint disponibilizado(https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json)

// using System.Text.Json;

// try
// {
//     using(HttpClient client = new HttpClient())
//     {
//         string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
//         var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;
//         foreach(var pais in paises)
//         {
//             System.Console.WriteLine(pais.Resume);
//         }
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

//Modelar e desserializar a classe Carro, que pode ser encontrada no endpoint disponibilizado(https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json)

// try
// {
//     using(HttpClient client = new HttpClient())
//     {
//         string reposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
//         var Carros = JsonSerializer.Deserialize<List<Carro>>(reposta)!;
//         foreach(var carro in Carros)
//         {
//             System.Console.WriteLine(carro.FichaTecnica);
//         }
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

//Modelar e desserializar a classe Livro, que pode ser encontrada no endpoint disponibilizado(https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json)

// try
// {
//     using(HttpClient client = new HttpClient())
//     {
//         string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
//         var livros = JsonSerializer.Deserialize<List<Livros>>(resposta)!;
//         foreach(var livro in livros)
//         {
//             System.Console.WriteLine(livro.Resume);
//         }
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

//Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

// List<int> numeros = new List<int>{1, 1, 2, 3, 5, 5, 5, 5, 7, 8, 9, 40, 4};

// var numerosDiferentes = numeros.Distinct();

// foreach (var numbers in numerosDiferentes)
// {
//     System.Console.WriteLine(numbers);
// }

//Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

// List<Livro> Livros = new List<Livro>
// {
//     new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoLancamento = 2005 },
//     new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoLancamento = 2010 },
//     new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoLancamento = 1998 },
//     new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoLancamento = 2021 },
//     new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoLancamento = 2002 }
// };

// var Livro2000 = Livros.Where(Livro => Livro.AnoLancamento > 2000).OrderBy(Livro => Livro.Titulo).Select(Livro => Livro.Titulo);

// foreach (var Livro in Livro2000)
// {
//     System.Console.WriteLine($"- {Livro}");
// }

//Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.