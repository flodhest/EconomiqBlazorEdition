using Economiq.Shared.DTO;
using System.Net.Http.Json;

namespace Economiq.Client.Service
{
    public class UserService
    {
        private readonly ApiService _apiService;

        public UserService(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> CreateUser(UserDTO userDTO)
        {
            HttpResponseMessage response = await _apiService.GetUserClient().PostAsJsonAsync("createUser", userDTO);
            string responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> Login()
        {
            HttpResponseMessage response = await _apiService.GetUserClient().PostAsJsonAsync("login", String.Empty);
            string responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
