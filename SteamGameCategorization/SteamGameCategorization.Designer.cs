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
            WiseCorner wiseCorner1 = new WiseCorner();
            WiseCorner wiseCorner2 = new WiseCorner();
            this.txtVDFPath = new System.Windows.Forms.TextBox();
            this.btnSteamPath = new WiseClockie.Forms.WiseButton();
            this.categoryTree = new WiseClockie.Forms.WiseTreeView();
            this.avatarPinkgun = new System.Windows.Forms.PictureBox();
            this.midiControl = new WiseClockie.Forms.WiseButton();
            this.lblPreview = new System.Windows.Forms.Label();
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
            wiseCorner1.All = 0;
            wiseCorner1.BottomLeft = 0;
            wiseCorner1.BottomRight = 0;
            wiseCorner1.TopLeft = 0;
            wiseCorner1.TopRight = 0;
            this.btnSteamPath.CornerRadius = wiseCorner1;
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
            wiseCorner2.All = 0;
            wiseCorner2.BottomLeft = 0;
            wiseCorner2.BottomRight = 0;
            wiseCorner2.TopLeft = 0;
            wiseCorner2.TopRight = 0;
            this.midiControl.CornerRadius = wiseCorner2;
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
            // SteamGameCategorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(463, 390);
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
    }
}

