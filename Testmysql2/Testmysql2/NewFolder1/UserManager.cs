using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Testmysql2.NewFolder1
{
    class UserManager
    {
        const String URL = "http://192.168.1.10/webservice2/verUser.php";
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task <IEnumerable<User>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);
            if(res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<User>>(content);
            }
            return Enumerable.Empty<User>();
        }
    }
}
