
namespace OF.IconBrowser.Forms
{
    partial class IconBrowserParentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxEnlarge = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEnlarge
            // 
            this.checkBoxEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnlarge.AutoSize = true;
            this.checkBoxEnlarge.Location = new System.Drawing.Point(738, 14);
            this.checkBoxEnlarge.Name = "checkBoxEnlarge";
            this.checkBoxEnlarge.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEnlarge.TabIndex = 0;
            this.checkBoxEnlarge.Text = "Enlarge";
            this.checkBoxEnlarge.UseVisualStyleBackColor = true;
            this.checkBoxEnlarge.CheckStateChanged += new System.EventHandler(this.checkBoxEnlarge_CheckStateChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(47, 12);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(685, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.Location = new System.Drawing.Point(12, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(776, 400);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyIconToolStripMenuItem,
            this.copyBitmapToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(218, 92);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copyIconToolStripMenuItem
            // 
            this.copyIconToolStripMenuItem.Name = "copyIconToolStripMenuItem";
            this.copyIconToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyIconToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.copyIconToolStripMenuItem.Text = "Copy Icon";
            this.copyIconToolStripMenuItem.Click += new System.EventHandler(this.copyIconToolStripMenuItem_Click);
            // 
            // copyBitmapToolStripMenuItem
            // 
            this.copyBitmapToolStripMenuItem.Name = "copyBitmapToolStripMenuItem";
            this.copyBitmapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyBitmapToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.copyBitmapToolStripMenuItem.Text = "Copy Bitmap";
            this.copyBitmapToolStripMenuItem.Click += new System.EventHandler(this.copyBitmapToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 15);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 4;
            this.labelFilter.Text = "Filter";
            // 
            // IconBrowserParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.checkBoxEnlarge);
            this.Name = "IconBrowserParentForm";
            this.helpProviderHaestadForm.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icon Browser";
            this.SizeChanged += new System.EventHandler(this.IconBrowserParentForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEnlarge;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

