using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcproExtensionApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

      
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// 获取当前程序集的信息
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //// 获取程序集的完整名称
            //Console.WriteLine("Full Name: " + assembly.FullName);

            //// 获取程序集的位置
            //Console.WriteLine("Location: " + assembly.Location);

            //// 获取程序集的版本信息
            //AssemblyVersionAttribute version = assembly.GetCustomAttribute<AssemblyVersionAttribute>();
            //Console.WriteLine("Version: " + (version != null ? version.Version : "N/A"));

            //// 获取程序集的信息版本（通常包括版本号，构建日期等）
            //AssemblyFileVersionAttribute fileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            //Console.WriteLine("File Version: " + (fileVersion != null ? fileVersion.Version : "N/A"));

            //// 获取有关程序集版权的信息
            //AssemblyCompanyAttribute company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            //Console.WriteLine("Company: " + (company != null ? company.Company : "N/A"));

            //// 获取程序集的描述
            //AssemblyDescriptionAttribute description = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>();
            //Console.WriteLine("Description: " + (description != null ? description.Description : "N/A"));

            //// 获取程序集的产品名称
            //AssemblyProductAttribute product = assembly.GetCustomAttribute<AssemblyProductAttribute>();
            //Console.WriteLine("Product: " + (product != null ? product.Product : "N/A"));

            Application.Run(new AppStart());
        }
        
    }
}
