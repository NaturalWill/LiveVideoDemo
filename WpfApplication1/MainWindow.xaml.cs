using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string str1 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;//可获得当前执行的exe的文件名。  
            string str2 = Environment.CurrentDirectory;//获取和设置当前目录（即该进程从中启动的目录）的完全限定路径。
                                                       //备注 按照定义，如果该进程在本地或网络驱动器的根目录中启动，则此属性的值为驱动器名称后跟一个尾部反斜杠（如“C:\”）。如果该进程在子目录中启动，则此属性的值为不带尾部反斜杠的驱动器和子目录路径（如“C:\mySubDirectory”）。
            string str3 = System.IO.Directory.GetCurrentDirectory();//获取应用程序的当前工作目录。
            string str4 = AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集。
            string str5 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取或设置包含该应用程序的目录的名称。
            List<string> s = new List<string>();
            s.Add(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            // 获取模块的完整路径。
            s.Add(System.Environment.CurrentDirectory);
            //获取和设置当前目录(该进程从中启动的目录)的完全限定目录。
            s.Add(System.IO.Directory.GetCurrentDirectory());
            // 获取应用程序的当前工作目录。这个不一定是程序从中启动的目录啊，有可能程序放在C:\www里,这个函数有可能返回C:\Documents and Settings\ZYB\,或者C:\Program Files\Adobe\,有时不一定返回什么东东，我也搞不懂了。

            s.Add(System.AppDomain.CurrentDomain.BaseDirectory);
            //获取程序的基目录。

            s.Add(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            //获取和设置包括该应用程序的目录的名称。

            label.Content = "";
            foreach (string sss in s)
            {
                label.Content += "\n"+sss;

            }
        }
    }
}
