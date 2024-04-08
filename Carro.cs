using System.Text.Json.Serialization;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }
    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }
    public string FichaTecnica => $"\nMarca: {Marca}\nModelo: {Modelo}\nTipo: {Tipo}\nAno do carro: {Ano}";
}