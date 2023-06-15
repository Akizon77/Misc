using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VITS
{
    public static class Helper
    {
        public static async Task<HttpResponseMessage> Get(HttpRequestMessage request)
        { 
            HttpClient client = new HttpClient();
            return await client.SendAsync(request);
        }
    }
}
