using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode
{
    public static class Code003
    {
        public static void Run(string s)
        {
            var charlist = s.ToCharArray();
            var originLenth = s.Length;//原始字符长度
            var maxLenth = 0;//最大长度
            var start = 0;//指针位置1：起始标记
            var end = 0;//指针位置2：结束标记
            var resultStr = new List<char>();
            while (end < originLenth)//在指向最后一个字符之前
            {
                if (!resultStr.Contains(charlist[end]))//如果不包含end指向的当前字符
                {
                    resultStr.Add(charlist[end]);//添加进入列表
                    end++;//移向下一位
                    maxLenth = maxLenth > end - start ? maxLenth : end - start;//取end - start
                }
                else
                {
                    resultStr.Remove(charlist[start]);//移除起始字符
                    start++;//移向下一位
                }
            }
            Console.WriteLine(maxLenth);
        }
    }
}
