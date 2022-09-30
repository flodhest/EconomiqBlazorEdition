using Economiq.Shared.DTO;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Economiq.Shared;
namespace Economiq.Client.Service
{
    public class ExpenseCategoryService
    {
        private readonly ApiService _apiService;

        public ExpenseCategoryService(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> CreateExpenseCategory(ExpenseCategoryDTO dto)
        {
            HttpResponseMessage response = await _apiService.GetExpenseCategoryClient().PostAsJsonAsync("create", dto);
            string responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }


        public async Task<List<ExpenseCategoryDTO>> GetCategoryList()
        {
            var tmp = await _apiService.GetExpenseCategoryClient().GetFromJsonAsync<List<ExpenseCategoryDTO>>("listCategories");
            return tmp; 
        }
    }
}
