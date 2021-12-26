using Haestad.Framework.Application;
using Haestad.Framework.Windows.Forms.Forms;
using Haestad.Framework.Windows.Forms.Resources;
using Haestad.Support.Support;
using OF.IconBrowser.FormModel;
using OpenFlows.Application;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OF.IconBrowser.Forms
{
    public partial class IconBrowserParentForm : HaestadParentForm, IParentFormSurrogate
    {
        #region Constructor
        public IconBrowserParentForm(HaestadParentFormModel parentFormModel)
            : base(parentFormModel)
        {
            InitializeComponent();
        }
        #endregion

        #region Overridden methods
        protected override void InitializeVisually()
        {
            this.Icon = (Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.IconView];

            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ColumnHeadersVisible = false;
        }
        #endregion

        #region Public Methods
        public void SetParentWindowHandle(long handle)
        {
            //no-op
        }
        #endregion

        #region Private Methods
        private void LoadIcons()
        {
            var iconResources = IconBrowserFormModel.Filter(this.textBoxFilter.Text, this.checkBoxEnlarge.Checked);

            int imageWidth = 48 + 2;
            int imageHeigth = imageWidth;
            int columnCount = (int)(Width / imageWidth) - 1;


            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Add columns
            for (int i = 0; i < columnCount; i++)
                dataGridView.Columns.Add(new DataGridViewImageColumn() { Width = imageWidth });


            // Add rows
            int rowCount = (int)(iconResources.Count / columnCount) + 1;
            int counter = 0;
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView.Rows.Add();
                var row = dataGridView.Rows[i];
                row.Height = imageHeigth;

                for (int j = 0; j < columnCount; j++)
                {

                    if (iconResources.Count <= counter)
                        break;

                    var cell = dataGridView[j, i];
                    var iconResource = iconResources[counter];
                    cell.Value = iconResource.Bitmap;
                    cell.ToolTipText = $"{iconResource.Name}: {iconResource.Label}";

                    counter++;
                }
            }

        }
        #endregion

        #region Event Handlers

        private void IconBrowserParentForm_SizeChanged(object sender, EventArgs e)
        {
            LoadIcons();
        }

        private void IconBrowserParentForm_Load(object sender, EventArgs e)
        {
            LoadIcons();
        }
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            LoadIcons();
        }

        private void checkBoxEnlarge_CheckStateChanged(object sender, EventArgs e)
        {
            LoadIcons();
        }
        #endregion

        #region Private Properties
        private IconBrowserFormModel IconBrowserFormModel { get; set; } = new IconBrowserFormModel();
        #endregion

        
    }
}
