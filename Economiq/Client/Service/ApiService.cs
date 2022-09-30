using System.Net.Http;

namespace Economiq.Client.Service
{
    public class ApiService
    {
        private readonly IHttpClientFactory _httpClient;

        public ApiService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient GetExpenseClient()
        {
            return _httpClient.CreateClient("expense");
        }

        public HttpClient GetExpenseCategoryClient()
        {
            return _httpClient.CreateClient("expenseCategory");
        }

        public HttpClient GetRecipientClient()
        {
            return _httpClient.CreateClient("recipient");
        }

        public HttpClient GetUserClient()
        {
            return _httpClient.CreateClient("user");
        }

        public HttpClient GetBudgetClient()
        {
            return _httpClient.CreateClient("budget");
        }


    }
}
