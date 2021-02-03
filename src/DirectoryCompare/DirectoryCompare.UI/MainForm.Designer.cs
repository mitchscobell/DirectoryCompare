
namespace DirectoryCompare.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.buttonBrowseDirectoryCompare = new System.Windows.Forms.Button();
            this.textBoxCompareDirectory = new System.Windows.Forms.TextBox();
            this.labelCompareDirectory = new System.Windows.Forms.Label();
            this.buttonBrowseDirectorySource = new System.Windows.Forms.Button();
            this.textBoxSourceDirectory = new System.Windows.Forms.TextBox();
            this.labelDirectorySource = new System.Windows.Forms.Label();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSourceFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewCompareFiles = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSourceFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompareFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready.";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCompare);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOptions);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrowseDirectoryCompare);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCompareDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.labelCompareDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrowseDirectorySource);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSourceDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.labelDirectorySource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxFiles);
            this.splitContainer1.Size = new System.Drawing.Size(800, 404);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.Location = new System.Drawing.Point(12, 132);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompare.Location = new System.Drawing.Point(713, 132);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 0;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptions.Controls.Add(this.checkBoxRecursive);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 69);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(776, 57);
            this.groupBoxOptions.TabIndex = 7;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Compare Options";
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.Location = new System.Drawing.Point(6, 19);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRecursive.TabIndex = 0;
            this.checkBoxRecursive.Text = "Recursive";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseDirectoryCompare
            // 
            this.buttonBrowseDirectoryCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDirectoryCompare.Location = new System.Drawing.Point(713, 41);
            this.buttonBrowseDirectoryCompare.Name = "buttonBrowseDirectoryCompare";
            this.buttonBrowseDirectoryCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDirectoryCompare.TabIndex = 5;
            this.buttonBrowseDirectoryCompare.Text = "Browse";
            this.buttonBrowseDirectoryCompare.UseVisualStyleBackColor = true;
            this.buttonBrowseDirectoryCompare.Click += new System.EventHandler(this.buttonBrowseDirectoryCompare_Click);
            // 
            // textBoxCompareDirectory
            // 
            this.textBoxCompareDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompareDirectory.Location = new System.Drawing.Point(115, 43);
            this.textBoxCompareDirectory.Name = "textBoxCompareDirectory";
            this.textBoxCompareDirectory.Size = new System.Drawing.Size(592, 20);
            this.textBoxCompareDirectory.TabIndex = 4;
            // 
            // labelCompareDirectory
            // 
            this.labelCompareDirectory.AutoSize = true;
            this.labelCompareDirectory.Location = new System.Drawing.Point(12, 46);
            this.labelCompareDirectory.Name = "labelCompareDirectory";
            this.labelCompareDirectory.Size = new System.Drawing.Size(97, 13);
            this.labelCompareDirectory.TabIndex = 3;
            this.labelCompareDirectory.Text = "Compare Directory:";
            // 
            // buttonBrowseDirectorySource
            // 
            this.buttonBrowseDirectorySource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDirectorySource.Location = new System.Drawing.Point(713, 15);
            this.buttonBrowseDirectorySource.Name = "buttonBrowseDirectorySource";
            this.buttonBrowseDirectorySource.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDirectorySource.TabIndex = 2;
            this.buttonBrowseDirectorySource.Text = "Browse";
            this.buttonBrowseDirectorySource.UseVisualStyleBackColor = true;
            this.buttonBrowseDirectorySource.Click += new System.EventHandler(this.buttonBrowseDirectorySource_Click);
            // 
            // textBoxSourceDirectory
            // 
            this.textBoxSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceDirectory.Location = new System.Drawing.Point(115, 17);
            this.textBoxSourceDirectory.Name = "textBoxSourceDirectory";
            this.textBoxSourceDirectory.Size = new System.Drawing.Size(592, 20);
            this.textBoxSourceDirectory.TabIndex = 1;
            // 
            // labelDirectorySource
            // 
            this.labelDirectorySource.AutoSize = true;
            this.labelDirectorySource.Location = new System.Drawing.Point(20, 20);
            this.labelDirectorySource.Name = "labelDirectorySource";
            this.labelDirectorySource.Size = new System.Drawing.Size(89, 13);
            this.labelDirectorySource.TabIndex = 0;
            this.labelDirectorySource.Text = "Source Directory:";
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.splitContainer2);
            this.groupBoxFiles.Location = new System.Drawing.Point(12, 3);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(776, 227);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewSourceFiles);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewCompareFiles);
            this.splitContainer2.Size = new System.Drawing.Size(770, 208);
            this.splitContainer2.SplitterDistance = 405;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewSourceFiles
            // 
            this.dataGridViewSourceFiles.AllowUserToResizeRows = false;
            this.dataGridViewSourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSourceFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSourceFiles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSourceFiles.Name = "dataGridViewSourceFiles";
            this.dataGridViewSourceFiles.ReadOnly = true;
            this.dataGridViewSourceFiles.RowHeadersVisible = false;
            this.dataGridViewSourceFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSourceFiles.Size = new System.Drawing.Size(399, 202);
            this.dataGridViewSourceFiles.TabIndex = 0;
            // 
            // dataGridViewCompareFiles
            // 
            this.dataGridViewCompareFiles.AllowUserToResizeRows = false;
            this.dataGridViewCompareFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCompareFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompareFiles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCompareFiles.Name = "dataGridViewCompareFiles";
            this.dataGridViewCompareFiles.ReadOnly = true;
            this.dataGridViewCompareFiles.RowHeadersVisible = false;
            this.dataGridViewCompareFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCompareFiles.Size = new System.Drawing.Size(355, 202);
            this.dataGridViewCompareFiles.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Directory Compare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSourceFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompareFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonBrowseDirectorySource;
        private System.Windows.Forms.TextBox textBoxSourceDirectory;
        private System.Windows.Forms.Label labelDirectorySource;
        private System.Windows.Forms.Button buttonBrowseDirectoryCompare;
        private System.Windows.Forms.TextBox textBoxCompareDirectory;
        private System.Windows.Forms.Label labelCompareDirectory;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewSourceFiles;
        private System.Windows.Forms.DataGridView dataGridViewCompareFiles;
    }
}

