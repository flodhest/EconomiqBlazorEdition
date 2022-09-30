using Economiq.Shared.DTO;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Economiq.Client.Service
{
    public class ExpenseService
    {
        private readonly ApiService _apiService;
        
        public ExpenseService(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> CreateExpense(ExpenseDTO expenseDTO)
        {
            HttpResponseMessage response = await _apiService.GetExpenseClient().PostAsJsonAsync("createExpense", expenseDTO);
            string responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<List<GetExpenseDTO>> GetExpenses()
        {
            return await _apiService.GetExpenseClient().GetFromJsonAsync<List<GetExpenseDTO>>("listExpense");   
        }

        public async Task<List<GetExpenseDTO>> GetRecentExpenses()
        {
            return await _apiService.GetExpenseClient().GetFromJsonAsync<List<GetExpenseDTO>>("getRecent");
        }

    }
}
