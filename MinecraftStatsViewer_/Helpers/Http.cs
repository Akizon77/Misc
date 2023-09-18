using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftStatsViewer_.Helpers
{
    public static class Http
    {
        public static async Task<string> GetUserName(string uuid)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri($"https://sessionserver.mojang.com/session/minecraft/profile/{uuid}");
                request.Method = HttpMethod.Get;
                var response = await client.SendAsync(request);
                var result = await response.Content.ReadAsStringAsync();


                var j = JObject.Parse(result);
                return j["name"].ToString();
            }
            catch (Exception)
            {
                Logger.Debug($"无法获取UUID:{uuid} 玩家的用户名");
                return uuid;
            }
        }
    }
}
