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

using System.Text.Json;

try
{
    using(HttpClient client = new HttpClient())
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        foreach (var filme in filmes)
        {
            Console.WriteLine(filme.ShowDetails);
        }
    }
}
catch(Exception ex)
{
    System.Console.WriteLine($"Erro: {ex.Message}");
}