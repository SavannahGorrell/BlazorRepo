using YouthAndFamilyDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace YouthAndFamilyDB.Client.Services
{
    public class TeenService : ITeenService
    {
        private readonly HttpClient _httpClient;

        public TeenService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<HouseChurch> HouseChurches { get; set; } = new List<HouseChurch>();
        public List<Teen> Teens { get; set; } = new List<Teen>();

        public event Action OnChange;

        public async Task<List<Teen>> CreateTeen(Teen teen)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/teen", teen);
            Teens = await result.Content.ReadFromJsonAsync<List<Teen>>();
            OnChange.Invoke();
            return Teens;
        }

        public async Task<List<Teen>> DeleteTeen(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/teen/{id}");
            Teens = await result.Content.ReadFromJsonAsync<List<Teen>>();
            OnChange.Invoke();
            return Teens;
        }

        public async Task GetHouseChurches()
        {
            HouseChurches = await _httpClient.GetFromJsonAsync<List<HouseChurch>>($"api/teen/houseChurches");
        }

        public async Task<Teen> GetTeen(int id)
        {
            return await _httpClient.GetFromJsonAsync<Teen>($"api/teen/{id}");
        }

        public async Task<List<Teen>> GetTeens()
        {
            Teens = await _httpClient.GetFromJsonAsync<List<Teen>>("api/teen");
            return Teens;
        }

        public async Task<List<Teen>> UpdateTeen(Teen teen, int id)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/teen/{id}", teen);
            Teens = await result.Content.ReadFromJsonAsync<List<Teen>>();
            OnChange.Invoke();
            return Teens;
        }

    }
}