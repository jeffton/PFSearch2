namespace PFSearch2.Interface
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.searchButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.directoryBox = new System.Windows.Forms.TextBox();
      this.filenameBox = new System.Windows.Forms.TextBox();
      this.contentBox = new System.Windows.Forms.TextBox();
      this.directoryLabel = new System.Windows.Forms.Label();
      this.filenameLabel = new System.Windows.Forms.Label();
      this.contentLabel = new System.Windows.Forms.Label();
      this.resultsGroup = new System.Windows.Forms.GroupBox();
      this.resultContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openFilelocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusLabel = new System.Windows.Forms.Label();
      this.resultView = new PFSearch2.Interface.ListViewEx();
      this.fileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.argumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.resultsGroup.SuspendLayout();
      this.resultContextMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.argumentsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // searchButton
      // 
      this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.searchButton.Location = new System.Drawing.Point(459, 90);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 23);
      this.searchButton.TabIndex = 7;
      this.searchButton.Text = "&Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Enabled = false;
      this.cancelButton.Location = new System.Drawing.Point(543, 90);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 8;
      this.cancelButton.Text = "&Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // directoryBox
      // 
      this.directoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.directoryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.directoryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.directoryBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.argumentsBindingSource, "Folder", true));
      this.directoryBox.Location = new System.Drawing.Point(71, 12);
      this.directoryBox.Name = "directoryBox";
      this.directoryBox.Size = new System.Drawing.Size(547, 20);
      this.directoryBox.TabIndex = 1;
      // 
      // filenameBox
      // 
      this.filenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.filenameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.argumentsBindingSource, "NameSearch", true));
      this.filenameBox.Location = new System.Drawing.Point(71, 38);
      this.filenameBox.Name = "filenameBox";
      this.filenameBox.Size = new System.Drawing.Size(547, 20);
      this.filenameBox.TabIndex = 3;
      this.filenameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.argumentBox_KeyUp);
      // 
      // contentBox
      // 
      this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.contentBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.argumentsBindingSource, "ContentSearch", true));
      this.contentBox.Location = new System.Drawing.Point(71, 64);
      this.contentBox.Name = "contentBox";
      this.contentBox.Size = new System.Drawing.Size(547, 20);
      this.contentBox.TabIndex = 5;
      this.contentBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.argumentBox_KeyUp);
      // 
      // directoryLabel
      // 
      this.directoryLabel.AutoSize = true;
      this.directoryLabel.Location = new System.Drawing.Point(12, 15);
      this.directoryLabel.Name = "directoryLabel";
      this.directoryLabel.Size = new System.Drawing.Size(52, 13);
      this.directoryLabel.TabIndex = 0;
      this.directoryLabel.Text = "Search &in";
      // 
      // filenameLabel
      // 
      this.filenameLabel.AutoSize = true;
      this.filenameLabel.Location = new System.Drawing.Point(16, 41);
      this.filenameLabel.Name = "filenameLabel";
      this.filenameLabel.Size = new System.Drawing.Size(49, 13);
      this.filenameLabel.TabIndex = 2;
      this.filenameLabel.Text = "&Filename";
      // 
      // contentLabel
      // 
      this.contentLabel.AutoSize = true;
      this.contentLabel.Location = new System.Drawing.Point(21, 67);
      this.contentLabel.Name = "contentLabel";
      this.contentLabel.Size = new System.Drawing.Size(44, 13);
      this.contentLabel.TabIndex = 4;
      this.contentLabel.Text = "C&ontent";
      // 
      // resultsGroup
      // 
      this.resultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsGroup.Controls.Add(this.resultView);
      this.resultsGroup.Location = new System.Drawing.Point(12, 119);
      this.resultsGroup.Name = "resultsGroup";
      this.resultsGroup.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
      this.resultsGroup.Size = new System.Drawing.Size(606, 270);
      this.resultsGroup.TabIndex = 9;
      this.resultsGroup.TabStop = false;
      this.resultsGroup.Text = "Results";
      // 
      // resultContextMenu
      // 
      this.resultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilelocationToolStripMenuItem,
            this.openfileToolStripMenuItem,
            this.copyToolStripMenuItem});
      this.resultContextMenu.Name = "resultContextMenu";
      this.resultContextMenu.Size = new System.Drawing.Size(169, 70);
      // 
      // openFilelocationToolStripMenuItem
      // 
      this.openFilelocationToolStripMenuItem.Image = global::PFSearch2.Properties.Resources.folder;
      this.openFilelocationToolStripMenuItem.Name = "openFilelocationToolStripMenuItem";
      this.openFilelocationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.openFilelocationToolStripMenuItem.Text = "Open file &location";
      this.openFilelocationToolStripMenuItem.Click += new System.EventHandler(this.openFilelocationToolStripMenuItem_Click);
      // 
      // openfileToolStripMenuItem
      // 
      this.openfileToolStripMenuItem.Image = global::PFSearch2.Properties.Resources.page;
      this.openfileToolStripMenuItem.Name = "openfileToolStripMenuItem";
      this.openfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.openfileToolStripMenuItem.Text = "Open &file";
      this.openfileToolStripMenuItem.Click += new System.EventHandler(this.openfileToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = global::PFSearch2.Properties.Resources.page_copy;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // statusLabel
      // 
      this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.statusLabel.AutoEllipsis = true;
      this.statusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
      this.statusLabel.Location = new System.Drawing.Point(68, 95);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(385, 13);
      this.statusLabel.TabIndex = 6;
      this.statusLabel.Text = "Ready";
      // 
      // resultView
      // 
      this.resultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileColumn});
      this.resultView.ContextMenuStrip = this.resultContextMenu;
      this.resultView.FullRowSelect = true;
      this.resultView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.resultView.Location = new System.Drawing.Point(9, 19);
      this.resultView.Name = "resultView";
      this.resultView.Size = new System.Drawing.Size(588, 245);
      this.resultView.TabIndex = 2;
      this.resultView.UseCompatibleStateImageBehavior = false;
      this.resultView.View = System.Windows.Forms.View.Details;
      this.resultView.ItemActivate += new System.EventHandler(this.resultView_ItemActivate);
      this.resultView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.resultView_ItemDrag);
      this.resultView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.resultView_ItemSelectionChanged);
      // 
      // fileColumn
      // 
      this.fileColumn.Text = "File";
      this.fileColumn.Width = 600;
      // 
      // argumentsBindingSource
      // 
      this.argumentsBindingSource.DataSource = typeof(PFSearch2.Model.SearchArguments);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(630, 401);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.resultsGroup);
      this.Controls.Add(this.contentLabel);
      this.Controls.Add(this.filenameLabel);
      this.Controls.Add(this.directoryLabel);
      this.Controls.Add(this.contentBox);
      this.Controls.Add(this.filenameBox);
      this.Controls.Add(this.directoryBox);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.searchButton);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Plain Flippin\' File Search";
      this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
      this.resultsGroup.ResumeLayout(false);
      this.resultContextMenu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.argumentsBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.TextBox directoryBox;
    private System.Windows.Forms.TextBox filenameBox;
    private System.Windows.Forms.TextBox contentBox;
    private System.Windows.Forms.Label directoryLabel;
    private System.Windows.Forms.Label filenameLabel;
    private System.Windows.Forms.Label contentLabel;
    private System.Windows.Forms.GroupBox resultsGroup;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.BindingSource argumentsBindingSource;
    private System.Windows.Forms.ContextMenuStrip resultContextMenu;
    private System.Windows.Forms.ToolStripMenuItem openFilelocationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openfileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private ListViewEx resultView;
    private System.Windows.Forms.ColumnHeader fileColumn;
  }
}

