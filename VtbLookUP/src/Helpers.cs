using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace JsonVis
{
    public static class Helpers
    {
        public static bool Loaded = false;
        static Dictionary<string, string> groupDic = new();
        public static void Init()
        {
            if (!Loaded)
            {
                var s = System.IO.File.ReadAllText(Data.Path);
                var jo = JObject.Parse(s);
                var groupsjson = jo["guildinfolist"].ToArray();

                groupsjson.ToList().ForEach(x =>
                {
                    groupDic.Add(x["gid"].ToString(), x["name"].ToString());

                });
            }
            Loaded = true;
            //MessageBox.Show("Group Init Done");
        }
        public static string GetGroup(string gid)
        {
            string result;
            if (gid != "0")
            {
                groupDic.TryGetValue(gid, out result);
                //MessageBox.Show(result);
                return result??"无";
            }
            else return "无";
        }
    }
}
