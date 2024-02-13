using Blazored.LocalStorage;
using IMC.Models;

namespace IMC.Services
{
    public class BmiServiceLocalstorage : IBmiService
    {
        private const string LocalstorageName = "historicoBmi";
        private readonly ILocalStorageService _localStorage;

        public BmiServiceLocalstorage(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task AdicionarAsync(BMIModel model)
        {
            var models = await _localStorage.GetItemAsync<List<BMIModel>>(LocalstorageName) ?? [];
            models.Add(model);

            await _localStorage.SetItemAsync(LocalstorageName, models);
        }

        public async Task<List<BMIModel>> ListarAsync()
        {
            return await _localStorage.GetItemAsync<List<BMIModel>>(LocalstorageName) ?? [];
        }
    }
}
