using OF.IconBrowser.Forms;
using System;
using System.Windows.Forms;

namespace OF.IconBrowser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IconBrowserParentForm());

            return 0;
        }
    }
}
