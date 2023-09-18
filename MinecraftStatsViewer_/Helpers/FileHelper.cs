using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftStatsViewer_.Helpers
{
    public static class FileHelper
    {

        public static async Task<Dictionary<string,string>> ReadAllFiles(string path)
        {
            var files = Directory.GetFiles(path);
            var datasWithUUID = new Dictionary<string,string>();
            var datasWithName = new Dictionary<string,string>();
            foreach (var file in files)
            {
                datasWithUUID.Add(Path.GetFileName(file).Split(".")[0],File.ReadAllText(file));
            }
            foreach(var d in datasWithUUID)
            {
                var name = await Helpers.Http.GetUserName(d.Key);
                datasWithName.Add(name,d.Value);
            }

            return datasWithName;
        }
    }
}
