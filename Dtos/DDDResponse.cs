using System.Text.Json.Serialization;

namespace artigotech_integra_brasilapi.Dtos
{
    public class DDDResponse
    {
        public string? Estado { get; set; }
        public List<string>? Cidades { get; set; }
    }
}