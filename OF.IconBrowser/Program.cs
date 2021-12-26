using Haestad.Support.Library;
using OF.IconBrowser.Forms;
using OpenFlows.Application;
using OpenFlows.Water.Application;
using System;

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
            WaterApplicationManager.SetApplicationManager(new WaterApplicationManager());
            WaterApplicationManager.GetInstance().SetParentFormSurrogateDelegate(
                new ParentFormSurrogateDelegate((fm) =>
                {
                    return new IconBrowserParentForm(fm);
                }));

            WaterApplicationManager.GetInstance().Start();
            WaterApplicationManager.GetInstance().Stop();
            return 0;
        }
    }
}
