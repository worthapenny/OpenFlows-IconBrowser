namespace OF.IconBrowser.UserControls
{
    partial class IconBrowserUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSerach = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxOignalSize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSerach
            // 
            this.textBoxSerach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerach.Location = new System.Drawing.Point(0, 0);
            this.textBoxSerach.Name = "textBoxSerach";
            this.textBoxSerach.Size = new System.Drawing.Size(237, 20);
            this.textBoxSerach.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(330, 116);
            this.dataGridView.TabIndex = 3;
            // 
            // checkBoxOignalSize
            // 
            this.checkBoxOignalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOignalSize.AutoSize = true;
            this.checkBoxOignalSize.Location = new System.Drawing.Point(243, 3);
            this.checkBoxOignalSize.Name = "checkBoxOignalSize";
            this.checkBoxOignalSize.Size = new System.Drawing.Size(84, 17);
            this.checkBoxOignalSize.TabIndex = 6;
            this.checkBoxOignalSize.Text = "Original Size";
            this.checkBoxOignalSize.UseVisualStyleBackColor = true;
            // 
            // IconBrowserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxOignalSize);
            this.Controls.Add(this.textBoxSerach);
            this.Controls.Add(this.dataGridView);
            this.Name = "IconBrowserUserControl";
            this.Size = new System.Drawing.Size(330, 142);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSerach;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBoxOignalSize;
    }
}
