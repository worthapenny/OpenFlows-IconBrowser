using OF.IconBrowser.UserControlModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF.IconBrowser.UserControls
{
    public partial class IconView : UserControl
    {
        public IconView()
        {
            InitializeComponent();

            InitializeEvents();
        }

        #region Public Methods
        public void LoadControls(Bitmap bitmap, string name, string label, bool visible)
        {
            IconViewUserControlModel.Bitmap = bitmap;
            IconViewUserControlModel.Name = name;
            IconViewUserControlModel.Label = label;
            IconViewUserControlModel.Visible = visible;

            this.pictureBox.Image = bitmap;            
            this.Visible = visible;
            this.label.Text = label;
        }
        #endregion

        #region Private Events
        private void InitializeEvents()
        {
            //this.checkBoxOriginal.CheckStateChanged += (s, e) => 
        }
        #endregion

        #region Public Properties
        public PictureBoxSizeMode SizeMode { get { return this.pictureBox.SizeMode; } set { this.pictureBox.SizeMode = value; } } 
        #endregion


        #region Private Properties
        public IconViewUserControlModel IconViewUserControlModel { get; set; } = new IconViewUserControlModel();
        #endregion
    }
}
