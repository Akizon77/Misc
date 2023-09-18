using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using MinecraftStatsViewer_.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftStatsViewer_.Views
{
    public partial class Main : ObservableObject
    {
        [ObservableProperty]
        string worldPath = "";
        [ObservableProperty]
        ObservableCollection<MinecraftData> minecraftDatas = new();

        Dictionary<string, string> statsData;

        [RelayCommand]
        async Task SelectPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "存档|level.dat|所有文件|*.*";
            openFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                WorldPath = Path.GetDirectoryName(openFileDialog.FileName);
                Logger.Debug($"打开了存档{WorldPath}");
            }


            statsData = await Helpers.FileHelper.ReadAllFiles(WorldPath + "\\stats");


            foreach(var d in statsData)
            {
                var onlinetimes = JObject.Parse(d.Value)["stats"]["minecraft:custom"]["minecraft:play_time"].ToString();
                var onlinetime = Convert.ToInt32(onlinetimes);
                var realtime = onlinetime / 72000d;
                var t = new MinecraftData{ PlayerName = d.Key, Value = realtime };
                MinecraftDatas.Add(t);
            }   
            
        }

        
    }

    public class MinecraftData
    {
        public string PlayerName { get; set; }
        public double Value { get; set; }
    }
}
