using System.Text.Json.Serialization;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Name { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("idioma")]
    public string? Language { get; set; }
    public string Resume => $"\n\nNome do país: {Name} \nNome da capital: {Capital} \nIdioma falado: {Language}";
}