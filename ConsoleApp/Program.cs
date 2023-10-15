using System.Text;

namespace P
{
    class P
    {
        static void Main()
        {
            try
            {
                string? path;
                while (true)
                {
                    Console.WriteLine("将文件夹拖拽到控制台内(或粘贴路径)，并按下回车");
                    path = Console.ReadLine();
                    if (Directory.Exists(path))
                        break;
                    Console.WriteLine("文件夹不存在！");
                }
                Console.WriteLine("开始将UTF8转化为GB2312");
                var codeing = CodePagesEncodingProvider.Instance;
                //codeing
                //    .GetEncodings()
                //    .ToList()
                //    .ForEach(x => Console.WriteLine($"{x.CodePage} {x.DisplayName}"));

                var files = Directory.GetFiles(path);

                foreach (var file in files)
                {
                    Console.Write(file);
                    var content = File.ReadAllText(file, Encoding.UTF8);
                    File.WriteAllText(file, content, codeing.GetEncoding(936));
                    Console.WriteLine("\t转化成功");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"出现异常");
                Console.WriteLine(ex.Message);
                Thread.Sleep(new TimeSpan(0,0,30));
            }
        }
    }
}
