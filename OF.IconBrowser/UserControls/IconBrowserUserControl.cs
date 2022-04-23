using OF.IconBrowser.UserControlModel;
using System;
using System.Windows.Forms;

namespace OF.IconBrowser.UserControls
{
    public partial class IconBrowserUserControl : UserControl
    {
        #region Constructor
        public IconBrowserUserControl()
        {
            InitializeComponent();

            InitializeEvents();
        }

        #endregion

        #region Overridden Methods
        protected override void OnLoad(EventArgs e)
        {
            SearchIcon();
            base.OnLoad(e);
        }
        #endregion

        #region Private Methods

        private void InitializeEvents()
        {
            this.textBoxSerach.TextChanged += (s, e) => SearchIcon();
            this.SizeChanged += (s, e) => SearchIcon();
            this.checkBoxOignalSize.CheckedChanged += (s, e) => SearchIcon();
        }
        private void SearchIcon()
        {
            var text = this.textBoxSerach.Text;
            IconBrowserUserControlModel.LoadGraphics(this.dataGridView, Width, text, checkBoxOignalSize.Checked);
        }
        #endregion

        #region Public Properties
        public IconBrowserUserControlModel IconBrowserUserControlModel { get; set; } = new IconBrowserUserControlModel();
        #endregion
    }
}
