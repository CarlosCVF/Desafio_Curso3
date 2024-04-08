using System.Text.Json.Serialization;

internal class Livros
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("Autor")]
    public string? Autor { get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }
    public string Resume => $"\nTitulo da obra: {Titulo}\nNome do Autor: {Autor}\nGenero: {Genero}\nQuantidade de paginas: {Paginas}";
}