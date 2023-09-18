using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using LibreHardwareMonitor.Hardware;

namespace PerformanceMonitorViewModel
{
    [ObservableObject]
    public partial class ViewModel
    {
        [ObservableProperty]
        public double cpuUsage;
        [ObservableProperty]
        public double gpuUsage;
        [ObservableProperty]
        public double memUsage;
        [ObservableProperty]
        public double diskUsage;

        [RelayCommand]
        void Refreah()
        {
            MemUsage = GetMemUsagePercentage();
            CpuUsage = GetCpuUsage();

        }
        [RelayCommand]
        async Task Load()
        {
            await Task.Run( () => {
                while (true)
                {
                    Refreah();
                    Thread.Sleep(500);
                    //Monitor();
                }
            });
            

        }


        public static double GetMemUsagePercentage()
        {
            return FormatSize(GetUsedPhys()) / FormatSize(GetTotalPhys()) * 100;
        }
        public static double GetCpuUsagePercentage()
        {
            return 0d;
        }
        public static double GetGpuUsagePercentage()
        {
            return 0d;
        }

        #region 内存
        #region 获得内存信息API
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref MEMORY_INFO mi);

        //定义内存的信息结构
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_INFO
        {
            public uint dwLength; //当前结构体大小
            public uint dwMemoryLoad; //当前内存使用率
            public ulong ullTotalPhys; //总计物理内存大小
            public ulong ullAvailPhys; //可用物理内存大小
            public ulong ullTotalPageFile; //总计交换文件大小
            public ulong ullAvailPageFile; //总计交换文件大小
            public ulong ullTotalVirtual; //总计虚拟内存大小
            public ulong ullAvailVirtual; //可用虚拟内存大小
            public ulong ullAvailExtendedVirtual; //保留 这个值始终为0
        }
        #endregion

        #region 格式化容量大小
        /// <summary>
        /// 格式化容量大小
        /// </summary>
        /// <param name="size">容量（B）</param>
        /// <returns>已格式化的容量</returns>
        private static double FormatSize(ulong size)
        {
            double d = size / 1024;
            return d;
        }
        #endregion

        #region 获得当前内存使用情况
        /// <summary>
        /// 获得当前内存使用情况
        /// </summary>
        /// <returns></returns>
        public static MEMORY_INFO GetMemoryStatus()
        {
            MEMORY_INFO mi = new MEMORY_INFO();
            mi.dwLength = (uint)System.Runtime.InteropServices.Marshal.SizeOf(mi);
            GlobalMemoryStatusEx(ref mi);
            return mi;
        }
        #endregion

        #region 获得当前可用物理内存大小
        /// <summary>
        /// 获得当前可用物理内存大小
        /// </summary>
        /// <returns>当前可用物理内存（B）</returns>
        public static ulong GetAvailPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return mi.ullAvailPhys;
        }
        #endregion

        #region 获得当前已使用的内存大小
        /// <summary>
        /// 获得当前已使用的内存大小
        /// </summary>
        /// <returns>已使用的内存大小（B）</returns>
        public static ulong GetUsedPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return (mi.ullTotalPhys - mi.ullAvailPhys);
        }
        #endregion

        #region 获得当前总计物理内存大小
        /// <summary>
        /// 获得当前总计物理内存大小
        /// </summary>
        /// <returns&gt;总计物理内存大小（B）&lt;/returns&gt;
        public static ulong GetTotalPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return mi.ullTotalPhys;
        }
        #endregion
        #endregion


        #region CPU

        //static PerformanceCounter cpuIdleCounter  = new PerformanceCounter("Processor", "% Idle Time","_Total");
        static PerformanceCounter cpuProcessorCounter = new PerformanceCounter("Processor Information", "% Processor Time","_Total");
        //static PerformanceCounter cpuUserCounter = new PerformanceCounter("Processor", "% User Time","_Total");
        public static double GetCpuUsage()
        {
            double cpuUsage = cpuProcessorCounter.NextValue();
            return cpuUsage == 0d ? 0.5d : cpuUsage;
        }

        #endregion

        #region Libre

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        public void Monitor()
        {
            Computer computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true
            };

            computer.Open();
            computer.Accept(new UpdateVisitor());

            foreach (IHardware hardware in computer.Hardware)
            {
                Debug.WriteLine("Hardware: {0}", hardware.Name);

                foreach (IHardware subhardware in hardware.SubHardware)
                {
                    Debug.WriteLine("\tSubhardware: {0}", subhardware.Name);

                    foreach (ISensor sensor in subhardware.Sensors)
                    {
                        Debug.WriteLine("\t\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                        
                    }
                }

                foreach (ISensor sensor in hardware.Sensors)
                {
                    Debug.WriteLine("\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                }
            }

            computer.Close();
        }

        #endregion
    }
}
