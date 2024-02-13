using IMC.Models;

namespace IMC.Services;

public interface IBmiService
{
    Task AdicionarAsync(BMIModel model);
    Task<List<BMIModel>> ListarAsync();
}