using IMC.Models;

namespace IMC.Services
{
    public class BmiServiceInMemory : IBmiService
    {
        private readonly List<BMIModel> _models = new();

        public Task AdicionarAsync(BMIModel model)
        {
            _models.Add(model);
            return Task.CompletedTask;
        }

		public Task<List<BMIModel>> ListarAsync()
        {
            return Task.FromResult(_models);
        }
	}
}
