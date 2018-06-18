using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace EBCS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (RunningInstance() != null)
            {
                Application.ExitThread();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //查找相同名称的进程 
            foreach (Process process in processes)
            {
                //忽略当前进程 
                if (process.Id != current.Id)
                {
                    //确认相同进程的程序运行位置是否一样. 
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance. 
                        return process;
                    }
                }
            }
            //No other instance was found, return null. 
            return null;
        } 
    }
}