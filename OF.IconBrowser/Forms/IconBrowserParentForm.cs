using Haestad.Framework.Windows.Forms.Forms;
using Haestad.Framework.Windows.Forms.Resources;
using Haestad.Framework.Windows.Forms.Support;
using Haestad.Support.Support;
using OF.IconBrowser.FormModel;
using OF.IconBrowser.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF.IconBrowser.Forms
{
    public partial class IconBrowserParentForm : HaestadParentForm
    {
        #region Constructor
        public IconBrowserParentForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Overridden methods

        protected override void InitializeVisually()
        {
            this.Icon = (Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.IconView];
            this.copyIconToolStripMenuItem.Image = ((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.Copy]).ToBitmap();
            this.copyBitmapToolStripMenuItem.Image = ((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.CopyWorksheetData]).ToBitmap();
            this.saveToolStripMenuItem.Image = ((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.Save]).ToBitmap();

            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ColumnHeadersVisible = false;
        }
        protected override void InitializeBindings()
        {
            AnimationFormManager.Current.ShouldAnimate = true;
            AnimationFormManager.Current.StartAnimation("Loading ions...", this);

            var task = LoadIconsAsync();

            // update the UI after the task is completed
            task.ContinueWith(t =>
            {
                AnimationFormManager.Current.StopAnimation();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        protected override void HaestadForm_Closing(object sender, CancelEventArgs acea)
        {
            // no need to close any project as no project was open...
            // do not call the base
        }
        #endregion

        #region Public Methods
        public void SetParentWindowHandle(long handle)
        {
            //no-op
        }
        #endregion

        #region Private 

        private async Task LoadIconsAsync()
        {
            var iconResources = await IconBrowserFormModel.FilterAsync(this.textBoxFilter.Text, this.checkBoxEnlarge.Checked);

            LoadGridViewWithIcons(iconResources);
        }


        private void LoadGridViewWithIcons(List<IconResourceModel> iconResources)
        {
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
                    cell.Tag = iconResource;
                    cell.Value = iconResource.Bitmap;
                    cell.ToolTipText = $"{iconResource.Name}: {iconResource.Label}";

                    counter++;
                }
            }
        }

        private void CopyIconTextToClip()
        {
            var text = $"(Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.{SelectedIcon?.Label}];";
            Clipboard.SetText(text);
        }

        private void CopyBitmapTextToClip()
        {
            var text = $"((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.{SelectedIcon?.Label}]).ToBitmap();";
            Clipboard.SetText(text);
        }
        private void SaveIconToFile()
        {
            var dialog = NewFileSaveDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveIconToFile(dialog.FileName);
            }
        }
        private void SaveIconToFile(string filePathToCreate)
        {
            try
            {
                if (filePathToCreate.ToLower().EndsWith("ico"))
                    SelectedIcon.Icon.Save(new FileStream(filePathToCreate, FileMode.Create));
                else
                    SelectedIcon.Bitmap.Save(new FileStream(filePathToCreate, FileMode.Create), ImageFormat.Png);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Exception:\n{ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private SaveFileDialog NewFileSaveDialog()
        {
            var dialog = new SaveFileDialog();
            dialog.RestoreDirectory = true;
            dialog.Title = "Save File";
            dialog.DefaultExt = "ico";
            dialog.Filter = "ICO files (*.ico)|*.ico|PNG file (*.png)|*.png";
            dialog.CheckPathExists = true;

            return dialog;
        }
        #endregion

        #region Event Handlers

        private void IconBrowserParentForm_SizeChanged(object sender, EventArgs e)
        {
            _ = LoadIconsAsync();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            _ = LoadIconsAsync();
        }

        private void checkBoxEnlarge_CheckStateChanged(object sender, EventArgs e)
        {
            _ = LoadIconsAsync();
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                var hitTest = dataGridView.HitTest(e.X, e.Y);
                dataGridView.ClearSelection();
                dataGridView.CurrentCell = dataGridView.Rows[hitTest.RowIndex].Cells[hitTest.ColumnIndex];
                dataGridView.CurrentCell.Selected = true;
            }
        }
        private void copyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyIconTextToClip();
        }

        private void copyBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyBitmapTextToClip();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveIconToFile();
        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var text = $"(Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.{SelectedIcon?.Label}];";
            this.copyIconToolStripMenuItem.ToolTipText = $"{text}";

            text = $"((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.{SelectedIcon?.Label}]).ToBitmap();";
            this.copyBitmapToolStripMenuItem.ToolTipText = $"{text}";

            this.saveToolStripMenuItem.ToolTipText = $"Save '{SelectedIcon?.Label}' to a file as ICO or PNG.";
        }
        #endregion

        #region Private Properties
        private IconBrowserFormModel IconBrowserFormModel { get; set; } = new IconBrowserFormModel();

        private IconResourceModel SelectedIcon =>
            this.dataGridView.SelectedCells?.Count > 0
            ? this.dataGridView.SelectedCells[0].Tag as IconResourceModel
            : null;

        #endregion

       
    }
}
