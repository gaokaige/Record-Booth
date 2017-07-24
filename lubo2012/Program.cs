using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace lubo2012
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool noInstance;

            Mutex mutex = new Mutex(true, "Global\\" + Assembly.GetExecutingAssembly().FullName, out noInstance);

            if (noInstance)
            {
                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序已经启动，请不要同时运行多次。");
                Application.Exit();
            }
        }
    }
}