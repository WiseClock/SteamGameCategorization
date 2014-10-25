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
            this.steamPath = new System.Windows.Forms.TextBox();
            this.btnSteamPath = new WiseClockie.Forms.WiseButton();
            this.categoryTree = new WiseClockie.Forms.WiseTreeView();
            this.SuspendLayout();
            // 
            // steamPath
            // 
            this.steamPath.Location = new System.Drawing.Point(12, 12);
            this.steamPath.Name = "steamPath";
            this.steamPath.ReadOnly = true;
            this.steamPath.Size = new System.Drawing.Size(199, 23);
            this.steamPath.TabIndex = 0;
            // 
            // btnSteamPath
            // 
            wiseCorner1.All = 0;
            wiseCorner1.BottomLeft = 0;
            wiseCorner1.BottomRight = 0;
            wiseCorner1.TopLeft = 0;
            wiseCorner1.TopRight = 0;
            this.btnSteamPath.CornerRadius = wiseCorner1;
            this.btnSteamPath.Location = new System.Drawing.Point(217, 12);
            this.btnSteamPath.Name = "btnSteamPath";
            this.btnSteamPath.Size = new System.Drawing.Size(107, 23);
            this.btnSteamPath.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.btnSteamPath.TabIndex = 3;
            this.btnSteamPath.Text = "选择&VDF文件...";
            this.btnSteamPath.UseVisualStyleBackColor = true;
            // 
            // categoryTree
            // 
            this.categoryTree.FullRowSelect = true;
            this.categoryTree.HotTracking = true;
            this.categoryTree.Location = new System.Drawing.Point(12, 41);
            this.categoryTree.Name = "categoryTree";
            this.categoryTree.Size = new System.Drawing.Size(312, 290);
            this.categoryTree.TabIndex = 4;
            // 
            // SteamGameCategorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(336, 343);
            this.Controls.Add(this.categoryTree);
            this.Controls.Add(this.btnSteamPath);
            this.Controls.Add(this.steamPath);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SteamGameCategorization";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SteamGameCategorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamPath;
        private WiseClockie.Forms.WiseButton btnSteamPath;
        private WiseClockie.Forms.WiseTreeView categoryTree;
    }
}

