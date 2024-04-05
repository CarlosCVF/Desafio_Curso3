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
//     Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.{ex}");
// }

//Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
