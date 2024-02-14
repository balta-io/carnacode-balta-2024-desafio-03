using Imc.Models.Enums;

namespace Imc.Models;

public class ImcResult
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public EStatusImc Status { get; set; } = EStatusImc.Ruim;
    public string Icon => (Status == EStatusImc.Ruim) ? "⛔" : "✅";
}