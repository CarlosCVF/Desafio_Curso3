using System.Text.Json.Serialization;

internal class Filme
{
    [JsonPropertyName ("title")]
    public string? Name { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }
    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    public string ShowDetails => $"\nNome do filme: {Name} \nAno de lançamento: {Ano}\nElenco do filme: {Elenco}\nNota do filme: {Nota}";

    // public void ShowTitles()
    // {
    //     System.Console.WriteLine($"Nome do filme: {Name}");
    //     System.Console.WriteLine($"Ano de lançamento: {Ano}");
    //     System.Console.WriteLine($"Elenco do filme: {Elenco}");
    //     System.Console.WriteLine($"Nota do filme: {Nota}");
    // }
}