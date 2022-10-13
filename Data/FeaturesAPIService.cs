using System.Net.Http.Json;

namespace TeamCollaboration.FeaturesAPI
{
    public class FeaturesAPIService
    {
        private readonly HttpClient http;

        public FeaturesAPIService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<FeaturesType[]?> GetFeatures()
        {
            return await this.http.GetFromJsonAsync<FeaturesType[]>("https://testingapivirtually.com/features");
        }
    }
}