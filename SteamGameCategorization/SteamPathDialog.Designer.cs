namespace SteamGameCategorization
{
    partial class SteamPathDialog
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
            WiseCorner wiseCorner7 = new WiseCorner();
            WiseCorner wiseCorner8 = new WiseCorner();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsePath = new WiseClockie.Forms.WiseButton();
            this.btnSelectPath = new WiseClockie.Forms.WiseButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.LightSteelBlue;
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.path.Location = new System.Drawing.Point(12, 33);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(262, 22);
            this.path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "已检测到您Steam安装路径：";
            // 
            // btnUsePath
            // 
            this.btnUsePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            wiseCorner7.All = 0;
            wiseCorner7.BottomLeft = 0;
            wiseCorner7.BottomRight = 0;
            wiseCorner7.TopLeft = 0;
            wiseCorner7.TopRight = 0;
            this.btnUsePath.CornerRadius = wiseCorner7;
            this.btnUsePath.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUsePath.ForeColor = System.Drawing.Color.White;
            this.btnUsePath.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnUsePath.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(166)))), ((int)(((byte)(20)))));
            this.btnUsePath.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnUsePath.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.btnUsePath.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(166)))), ((int)(((byte)(20)))));
            this.btnUsePath.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnUsePath.Location = new System.Drawing.Point(27, 70);
            this.btnUsePath.Name = "btnUsePath";
            this.btnUsePath.Size = new System.Drawing.Size(162, 52);
            this.btnUsePath.SubText = "这就是我的Steam文件夹";
            this.btnUsePath.SubTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUsePath.SubTextFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsePath.TabIndex = 2;
            this.btnUsePath.Text = "点头";
            this.btnUsePath.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(155)))), ((int)(((byte)(203)))));
            wiseCorner8.All = 0;
            wiseCorner8.BottomLeft = 0;
            wiseCorner8.BottomRight = 0;
            wiseCorner8.TopLeft = 0;
            wiseCorner8.TopRight = 0;
            this.btnSelectPath.CornerRadius = wiseCorner8;
            this.btnSelectPath.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectPath.ForeColor = System.Drawing.Color.White;
            this.btnSelectPath.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(137)))), ((int)(((byte)(179)))));
            this.btnSelectPath.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.btnSelectPath.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(155)))), ((int)(((byte)(203)))));
            this.btnSelectPath.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.btnSelectPath.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.btnSelectPath.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(137)))), ((int)(((byte)(179)))));
            this.btnSelectPath.Location = new System.Drawing.Point(188, 70);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(69, 52);
            this.btnSelectPath.SubText = "手动选择";
            this.btnSelectPath.SubTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectPath.SubTextFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "摇头";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(57, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "（关闭窗口可手动选择VDF文件）";
            // 
            // SteamPathDialog
            // 
            this.AcceptButton = this.btnUsePath;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnUsePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamPathDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamPathDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label1;
        private WiseClockie.Forms.WiseButton btnSelectPath;
        private WiseClockie.Forms.WiseButton btnUsePath;
        private System.Windows.Forms.Label label2;
    }
}