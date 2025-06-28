using RestSharp;
using Newtonsoft.Json;
using Xceed.Wpf.Toolkit;


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
                RestResponse restResponse = await DataLibrary.Config.Endpoints._restClient.ExecuteAsync(request);

                if (!restResponse.IsSuccessful)
                {
                    
                    throw Exception.ReferenceEquals(restResponse.ErrorException, null)
                        ? new Exception($"Error fetching data: {restResponse.StatusCode} - {restResponse.Content}")
                        : restResponse.ErrorException;
                    
                }
                
                return System.Text.Json.JsonSerializer.Deserialize<T>(restResponse.Content ?? "");
            }
            catch (Exception ex)
            {
                throw Exception.ReferenceEquals(ex, null)
                    ? new Exception("An error occurred while fetching data from the API.", ex)
                    : ex;
            }
        }
    }
}
