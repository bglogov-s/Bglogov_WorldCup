using RestSharp;
using Newtonsoft.Json;


namespace DataLibrary.Services
{
    public static class ApiService
    {
        private static readonly RestClient _client = new RestClient("https://worldcup-vua.nullbit.hr");

        public static async Task<T?> FetchFromApiAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);

            try
            {
                var response = await _client.ExecuteAsync(request);

                if (!response.IsSuccessful)
                {
                    throw new Exception($"API Error: {response.StatusCode} - {response.ErrorMessage}");
                }

                return JsonConvert.DeserializeObject<T>(response.Content ?? "");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
