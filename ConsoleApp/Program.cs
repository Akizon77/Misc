using System.Diagnostics;

List<string> urlList = new()
{
    "https://www.bilibili.com/",
    "https://www.taobao.com/",
    "https://xiaomirom.com/",
    "https://zh.moegirl.org.cn/Mainpage",
    "https://www.zhihu.com/",
    "https://starxn.com/",
    "https://pinyin.sogou.com/dict/",
    "https://learn.microsoft.com/",
    "https://gamepad-tester.com/",
    "https://2heng.xin/theme-sakura/",
    "https://ithelp.ithome.com.tw/",
    "https://blog.nuoyis.net/477.html",
    "https://www.mcmod.cn/",
    "https://juejin.cn/"

};
Stopwatch stopwatch = Stopwatch.StartNew();

urlList.ForEach(l => Download(l)); // 同步下载
//urlList.ForEach(l => Task.Run( () => Download(l)));

//List<Task> tasks = new();
//urlList.ForEach(url => tasks.Add(Task.Run(() => Download(url))));
//Task.WhenAll(tasks).Wait();

//List<Task> tasks = new();
//urlList.ForEach(url => tasks.Add(DownloadAsync(url)));
//Task.WhenAll(tasks).Wait();

stopwatch.Stop();
Console.WriteLine("所有任务完成，用时 " + stopwatch.Elapsed.TotalSeconds + " 秒");
Console.ReadLine();



void Download(string url)
{
    HttpClient client = new HttpClient();
    var request = new HttpRequestMessage(HttpMethod.Get, url);
    var r = client.SendAsync(request).GetAwaiter().GetResult();
    var l = r.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
    Console.WriteLine($"{url} 返回长度：{l.Length}");
}
async Task DownloadAsync(string url)
{
    HttpClient client = new HttpClient();
    var request = new HttpRequestMessage(HttpMethod.Get, url);
    var r = await client.SendAsync(request);
    var l = await r.Content.ReadAsByteArrayAsync();
    Console.WriteLine($"{url} 返回长度：{l.Length}");
}
