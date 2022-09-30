using Economiq.Shared.DTO;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Economiq.Client.Service
{
    public class BudgetService
    {
        private readonly ApiService _apiService;
        private HttpClient client;
        public BudgetService(ApiService apiService)
        {
            _apiService = apiService;
            client = _apiService.GetBudgetClient();
        }

        public async Task<List<ListBudgetDTO>> GetAllBudgets()
        {
            List<ListBudgetDTO> budgets = await client.GetFromJsonAsync<List<ListBudgetDTO>>("listBudgets");
            return budgets;
        }

        public async Task<ListBudgetDTO> GetBudgetById(Guid id)
        {
            //string json = await client.GetStringAsync($"getBudgetById/{id}");
            //ListBudgetDTO budget = JsonConvert.DeserializeObject<ListBudgetDTO>(json);
            ListBudgetDTO budget = await client.GetFromJsonAsync<ListBudgetDTO>($"getBudgetById/{id}");
            return budget;
        }
    }
}
