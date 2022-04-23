using Haestad.Framework.Windows.Forms.Resources;
using Haestad.Support.Support;
using OF.IconBrowser.UserControlModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OF.IconBrowser.Form
{
    public partial class IconBrowserForm : System.Windows.Forms.Form
    {
        #region Constructor
        public IconBrowserForm()
        {
            InitializeComponent();
            InitializeVisually();
        }
        #endregion

        #region Private Methods
        private void InitializeVisually()
        {
            this.Icon = (Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.Search];
            this.Text = "Icon Browser";


            var iconBrowserUCM = new IconBrowserUserControlModel();
            this.flowLayoutPanel1.Controls.AddRange(
                iconBrowserUCM.GetIconViews().Select(i => i as Control).ToArray());
        }
        #endregion      
    }
}
