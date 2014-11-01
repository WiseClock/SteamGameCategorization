namespace SteamGameCategorization
{
    partial class SteamGameCategorization
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
            WiseCorner wiseCorner5 = new WiseCorner();
            WiseCorner wiseCorner6 = new WiseCorner();
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Category", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Genre", System.Windows.Forms.HorizontalAlignment.Left);
            this.txtVDFPath = new System.Windows.Forms.TextBox();
            this.btnSteamPath = new WiseClockie.Forms.WiseButton();
            this.categoryTree = new WiseClockie.Forms.WiseTreeView();
            this.avatarPinkgun = new System.Windows.Forms.PictureBox();
            this.midiControl = new WiseClockie.Forms.WiseButton();
            this.lblPreview = new System.Windows.Forms.Label();
            this.categoryListView = new WiseClockie.Forms.WiseListView();
            this.categoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryEngName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryListViewMenu = new System.Windows.Forms.ContextMenu();
            this.menuSelect = new System.Windows.Forms.MenuItem();
            this.menuUnselect = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPinkgun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVDFPath
            // 
            this.txtVDFPath.Location = new System.Drawing.Point(58, 12);
            this.txtVDFPath.Name = "txtVDFPath";
            this.txtVDFPath.ReadOnly = true;
            this.txtVDFPath.Size = new System.Drawing.Size(199, 23);
            this.txtVDFPath.TabIndex = 0;
            // 
            // btnSteamPath
            // 
            wiseCorner5.All = 0;
            wiseCorner5.BottomLeft = 0;
            wiseCorner5.BottomRight = 0;
            wiseCorner5.TopLeft = 0;
            wiseCorner5.TopRight = 0;
            this.btnSteamPath.CornerRadius = wiseCorner5;
            this.btnSteamPath.Location = new System.Drawing.Point(263, 12);
            this.btnSteamPath.Name = "btnSteamPath";
            this.btnSteamPath.Size = new System.Drawing.Size(107, 23);
            this.btnSteamPath.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.btnSteamPath.TabIndex = 3;
            this.btnSteamPath.Text = "选择&VDF文件...";
            this.btnSteamPath.UseVisualStyleBackColor = true;
            this.btnSteamPath.Click += new System.EventHandler(this.btnSteamPath_Click);
            // 
            // categoryTree
            // 
            this.categoryTree.FullRowSelect = true;
            this.categoryTree.HotTracking = true;
            this.categoryTree.Location = new System.Drawing.Point(12, 79);
            this.categoryTree.Name = "categoryTree";
            this.categoryTree.Size = new System.Drawing.Size(160, 299);
            this.categoryTree.TabIndex = 4;
            // 
            // avatarPinkgun
            // 
            this.avatarPinkgun.Image = global::SteamGameCategorization.Properties.Resources.pinkgun;
            this.avatarPinkgun.Location = new System.Drawing.Point(12, 12);
            this.avatarPinkgun.Name = "avatarPinkgun";
            this.avatarPinkgun.Size = new System.Drawing.Size(40, 40);
            this.avatarPinkgun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPinkgun.TabIndex = 5;
            this.avatarPinkgun.TabStop = false;
            // 
            // midiControl
            // 
            wiseCorner6.All = 0;
            wiseCorner6.BottomLeft = 0;
            wiseCorner6.BottomRight = 0;
            wiseCorner6.TopLeft = 0;
            wiseCorner6.TopRight = 0;
            this.midiControl.CornerRadius = wiseCorner6;
            this.midiControl.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.midiControl.Location = new System.Drawing.Point(12, 12);
            this.midiControl.Name = "midiControl";
            this.midiControl.Size = new System.Drawing.Size(12, 12);
            this.midiControl.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.midiControl.TabIndex = 6;
            this.midiControl.Text = "■";
            this.midiControl.UseVisualStyleBackColor = true;
            this.midiControl.Click += new System.EventHandler(this.midiControl_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(9, 59);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(32, 17);
            this.lblPreview.TabIndex = 7;
            this.lblPreview.Text = "预览";
            // 
            // categoryListView
            // 
            this.categoryListView.CheckBoxes = true;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryName,
            this.categoryID,
            this.categoryEngName});
            this.categoryListView.FullRowSelect = true;
            listViewGroup5.Header = "Category";
            listViewGroup5.Name = "groupCategory";
            listViewGroup6.Header = "Genre";
            listViewGroup6.Name = "groupGenre";
            this.categoryListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.categoryListView.LabelEdit = true;
            this.categoryListView.Location = new System.Drawing.Point(227, 79);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(224, 299);
            this.categoryListView.TabIndex = 8;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            // 
            // categoryID
            // 
            this.categoryID.Text = "ID";
            this.categoryID.Width = 30;
            // 
            // categoryEngName
            // 
            this.categoryEngName.Text = "原名";
            this.categoryEngName.Width = 81;
            // 
            // categoryName
            // 
            this.categoryName.Text = "分类名";
            this.categoryName.Width = 92;
            // 
            // categoryListViewMenu
            // 
            this.categoryListViewMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuSelect,
            this.menuUnselect,
            this.menuItem1,
            this.menuEdit});
            // 
            // menuSelect
            // 
            this.menuSelect.Index = 0;
            this.menuSelect.Text = "使用(&S)";
            this.menuSelect.Click += new System.EventHandler(this.menuSelect_Click);
            // 
            // menuUnselect
            // 
            this.menuUnselect.Index = 1;
            this.menuUnselect.Text = "取消(&U)";
            this.menuUnselect.Click += new System.EventHandler(this.menuUnselect_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 3;
            this.menuEdit.Text = "编辑(&E)";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // SteamGameCategorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(463, 390);
            this.Controls.Add(this.categoryListView);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.midiControl);
            this.Controls.Add(this.avatarPinkgun);
            this.Controls.Add(this.categoryTree);
            this.Controls.Add(this.btnSteamPath);
            this.Controls.Add(this.txtVDFPath);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SteamGameCategorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Game Categorization";
            this.Load += new System.EventHandler(this.SteamGameCategorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPinkgun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVDFPath;
        private WiseClockie.Forms.WiseButton btnSteamPath;
        private WiseClockie.Forms.WiseTreeView categoryTree;
        private System.Windows.Forms.PictureBox avatarPinkgun;
        private WiseClockie.Forms.WiseButton midiControl;
        private System.Windows.Forms.Label lblPreview;
        private WiseClockie.Forms.WiseListView categoryListView;
        private System.Windows.Forms.ColumnHeader categoryName;
        private System.Windows.Forms.ColumnHeader categoryID;
        private System.Windows.Forms.ColumnHeader categoryEngName;
        private System.Windows.Forms.ContextMenu categoryListViewMenu;
        private System.Windows.Forms.MenuItem menuSelect;
        private System.Windows.Forms.MenuItem menuUnselect;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuEdit;
    }
}

