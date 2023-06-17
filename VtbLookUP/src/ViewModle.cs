using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;

namespace JsonVis
{
    public partial class ViewModle : ObservableObject
    {
        public ViewModle() { Instance = this; }
        public static ViewModle Instance;
        [ObservableProperty]
        string testtext = "";
        [ObservableProperty]
        public ObservableCollection<VT> vTS = new();


        [RelayCommand]
        async void loadonce()
        {
            VTS.Clear();
            try
            {
                var s = await System.IO.File.ReadAllTextAsync(SelectedFilePath);
                Helpers.Init();
                var jo = JObject.Parse(s);
                VTS.Add(new VT()
                {
                    Uid = "UID",
                    Name = "Name",
                    Gid = "Group"
                });

                var array = jo["fulldatalist"].ToArray();
                array.ToList().ForEach(v => 
                {
                    var list = v["vlist"];
                    string gid = v["gid"].ToString();
                    list.ToList().ForEach( x =>
                    {
                        VTS.Add(new VT()
                        {
                            Uid =  x["uid"].ToString(),
                            Name = x["name"].ToString(),
                            Gid = Helpers.GetGroup(gid)
                        });
                    });
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),e.Message);
                
            }
            

            //var array = jo["fulldatalist"][0]["vlist"].ToArray();
            //array.ToList().ForEach(x =>
            //{
            //    VTS.Add(
            //        new VT()
            //        {
            //            Uid = x["uid"].ToString(),
            //            Name = x["name"].ToString()
            //        });
            //    //Testtext = Testtext + x["name"].ToString() + "\n";
            //});



            Testtext = "Done";
        }
        [ObservableProperty]
        public string selectedFilePath = "C:\\Users\\hytf2\\Downloads\\finalresult.json";
        [RelayCommand]
        void Selectfile()
        {
            var openfiledialog = new OpenFileDialog()
            {
                Filter = "Files(*.json)|*.json"
            };
            openfiledialog.ShowDialog();
            SelectedFilePath = openfiledialog.FileName;
            Data.Path = SelectedFilePath;
        }


    }
    public class VT
    {
        public string Uid { get; set; }
        public string Name { get;set; }
        public string Gid { get;set; }
    }
}
