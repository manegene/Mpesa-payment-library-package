using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;

namespace Mpesa_pament_lib
{
    public class BaseImplementation : BaseInterface
    {
        private readonly HttpClient _httpClient;
        public BaseImplementation(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AuthResponse> Auth(string username, string password, bool dev)
        {
            var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));

            Constants constants = new();
            var response = new AuthResponse();

            UriBuilder Uri = new(dev ?

                constants.Dev + "oauth/v1/generate?grant_type=client_credentials" :

             constants.Prod + "oauth/v1/generate?grant_type=client_credentials"
             );

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

            var token = await _httpClient.GetAsync(Uri.ToString());
            //response is successful, so retun the token and expiry
            if(token != null && token.IsSuccessStatusCode)
            {
                var result= token.Content.ReadAsStringAsync().Result;
                if(result != null)
                {
                    response=  JsonConvert.DeserializeObject<AuthResponse>(result);
                }
                return response;
            
            }
            //http error encountered
            return response;






        }

    }
}