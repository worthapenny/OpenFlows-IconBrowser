using OF.IconBrowser.UserControls;

namespace OF.IconBrowser.Form
{
    partial class IconBrowserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OF.IconBrowser.UserControlModel.IconBrowserUserControlModel iconBrowserUserControlModel1 = new OF.IconBrowser.UserControlModel.IconBrowserUserControlModel();
            this.iconBrowserUserControl = new OF.IconBrowser.UserControls.IconBrowserUserControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // iconBrowserUserControl
            // 
            this.iconBrowserUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconBrowserUserControl.IconBrowserUserControlModel = iconBrowserUserControlModel1;
            this.iconBrowserUserControl.Location = new System.Drawing.Point(12, 12);
            this.iconBrowserUserControl.Name = "iconBrowserUserControl";
            this.iconBrowserUserControl.Size = new System.Drawing.Size(446, 426);
            this.iconBrowserUserControl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(483, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 419);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // IconBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.iconBrowserUserControl);
            this.Name = "IconBrowserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        private IconBrowserUserControl iconBrowserUserControl;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
