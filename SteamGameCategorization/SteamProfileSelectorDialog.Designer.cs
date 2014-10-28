namespace SteamGameCategorization
{
    partial class SteamProfileSelectorDialog
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
            this.steamProfiles = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new WiseClockie.Forms.WiseButton();
            this.SuspendLayout();
            // 
            // steamProfiles
            // 
            this.steamProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steamProfiles.FormattingEnabled = true;
            this.steamProfiles.Location = new System.Drawing.Point(12, 12);
            this.steamProfiles.Name = "steamProfiles";
            this.steamProfiles.Size = new System.Drawing.Size(179, 25);
            this.steamProfiles.TabIndex = 0;
            // 
            // btnConfirm
            // 
            wiseCorner1.All = 0;
            wiseCorner1.BottomLeft = 0;
            wiseCorner1.BottomRight = 0;
            wiseCorner1.TopLeft = 0;
            wiseCorner1.TopRight = 0;
            this.btnConfirm.CornerRadius = wiseCorner1;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(65, 43);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // SteamProfileSelectorDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(203, 75);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.steamProfiles);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamProfileSelectorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择Steam账号";
            this.ResumeLayout(false);

        }

        #endregion

        private WiseClockie.Forms.WiseButton btnConfirm;
        internal System.Windows.Forms.ComboBox steamProfiles;
    }
}