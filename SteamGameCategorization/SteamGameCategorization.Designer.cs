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
            this.steamPath = new System.Windows.Forms.TextBox();
            this.btnSteamPath = new LittleToolLib.Graphics.GradientButton();
            this.categoryTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // steamPath
            // 
            this.steamPath.Location = new System.Drawing.Point(12, 12);
            this.steamPath.Name = "steamPath";
            this.steamPath.ReadOnly = true;
            this.steamPath.Size = new System.Drawing.Size(226, 23);
            this.steamPath.TabIndex = 0;
            // 
            // btnSteamPath
            // 
            this.btnSteamPath.Location = new System.Drawing.Point(244, 12);
            this.btnSteamPath.Name = "btnSteamPath";
            this.btnSteamPath.NoLeft = false;
            this.btnSteamPath.NoRight = false;
            this.btnSteamPath.Size = new System.Drawing.Size(75, 23);
            this.btnSteamPath.TabIndex = 1;
            this.btnSteamPath.Text = "选择...";
            this.btnSteamPath.UseVisualStyleBackColor = true;
            // 
            // categoryTree
            // 
            this.categoryTree.Location = new System.Drawing.Point(12, 41);
            this.categoryTree.Name = "categoryTree";
            this.categoryTree.Size = new System.Drawing.Size(307, 290);
            this.categoryTree.TabIndex = 2;
            // 
            // SteamGameCategorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(this.categoryTree);
            this.Controls.Add(this.btnSteamPath);
            this.Controls.Add(this.steamPath);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SteamGameCategorization";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SteamGameCategorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamPath;
        private LittleToolLib.Graphics.GradientButton btnSteamPath;
        private System.Windows.Forms.TreeView categoryTree;
    }
}

