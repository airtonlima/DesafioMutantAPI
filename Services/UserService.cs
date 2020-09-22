using DesafioMutant.API.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioMutant.API.Services
{
    public class UserService
    {
        private static string BASE_URL = "https://jsonplaceholder.typicode.com/users";

        public static async Task<List<UserDTO>> getUsers()
        {
            List<UserDTO> list = new List<UserDTO>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(BASE_URL))
                {
                    string resData = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<UserDTO>>(resData);
                }
            }

            return list;
        }
    }
}
