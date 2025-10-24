using Microsoft.AspNetCore.Components;

namespace PortalKR.Models
{
    public class Servico
    {
        public string Categoria { get; set; } = "Serviço";
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Entrega { get; set; } = string.Empty;
        public string Prazo { get; set; } = string.Empty;
    }
}
