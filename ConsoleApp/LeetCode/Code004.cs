using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode
{
    public static class Code004
    {
        public static void Run(int[] nums1, int[] nums2)
        {
            var arr = new int[nums1.Length+nums2.Length];
            nums1.CopyTo(arr, 0);
            nums2.CopyTo(arr, nums1.Length);
            Array.Sort(arr);
            var mid =
                arr.Length % 2 == 0
                    ? (double)(arr[arr.Length / 2 - 1] + arr[arr.Length / 2 ]) / 2
                    : arr[arr.Length / 2 ];
            Console.WriteLine(mid);
        }
    }
}
