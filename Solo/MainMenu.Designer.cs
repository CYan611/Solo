namespace Solo
{
    partial class MainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sCBig = new System.Windows.Forms.SplitContainer();
            this.btnSwitchRole = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLauncher = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnMemberMenu = new System.Windows.Forms.Panel();
            this.btnMemberCenter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sCBig)).BeginInit();
            this.sCBig.Panel1.SuspendLayout();
            this.sCBig.SuspendLayout();
            this.pnMemberMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCBig
            // 
            this.sCBig.BackColor = System.Drawing.Color.White;
            this.sCBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCBig.IsSplitterFixed = true;
            this.sCBig.Location = new System.Drawing.Point(0, 0);
            this.sCBig.Name = "sCBig";
            this.sCBig.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCBig.Panel1
            // 
            this.sCBig.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sCBig.Panel1.Controls.Add(this.btnMin);
            this.sCBig.Panel1.Controls.Add(this.btnSwitchRole);
            this.sCBig.Panel1.Controls.Add(this.lblUserName);
            this.sCBig.Panel1.Controls.Add(this.lblLauncher);
            this.sCBig.Panel1.Controls.Add(this.lblTime);
            this.sCBig.Panel1MinSize = 10;
            // 
            // sCBig.Panel2
            // 
            this.sCBig.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sCBig.Size = new System.Drawing.Size(930, 612);
            this.sCBig.SplitterDistance = 75;
            this.sCBig.SplitterWidth = 3;
            this.sCBig.TabIndex = 11;
            // 
            // btnSwitchRole
            // 
            this.btnSwitchRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSwitchRole.FlatAppearance.BorderSize = 0;
            this.btnSwitchRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitchRole.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwitchRole.ForeColor = System.Drawing.Color.White;
            this.btnSwitchRole.Location = new System.Drawing.Point(556, 30);
            this.btnSwitchRole.Name = "btnSwitchRole";
            this.btnSwitchRole.Size = new System.Drawing.Size(101, 33);
            this.btnSwitchRole.TabIndex = 17;
            this.btnSwitchRole.Text = "切換身分";
            this.btnSwitchRole.UseVisualStyleBackColor = false;
            this.btnSwitchRole.Visible = false;
            this.btnSwitchRole.Click += new System.EventHandler(this.btnSwitchRole_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(664, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(230, 52);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "guest00001\r\n1213\r\n";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLauncher
            // 
            this.lblLauncher.BackColor = System.Drawing.Color.Transparent;
            this.lblLauncher.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLauncher.ForeColor = System.Drawing.Color.White;
            this.lblLauncher.Location = new System.Drawing.Point(897, 28);
            this.lblLauncher.Margin = new System.Windows.Forms.Padding(0);
            this.lblLauncher.Name = "lblLauncher";
            this.lblLauncher.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblLauncher.Size = new System.Drawing.Size(31, 31);
            this.lblLauncher.TabIndex = 15;
            this.lblLauncher.Text = "≡";
            this.lblLauncher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLauncher.Click += new System.EventHandler(this.lblLauncher_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(305, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(245, 40);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "使用時間: 00:00";
            // 
            // pnMemberMenu
            // 
            this.pnMemberMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnMemberMenu.Controls.Add(this.btnMemberCenter);
            this.pnMemberMenu.Location = new System.Drawing.Point(795, 63);
            this.pnMemberMenu.Name = "pnMemberMenu";
            this.pnMemberMenu.Size = new System.Drawing.Size(124, 31);
            this.pnMemberMenu.TabIndex = 12;
            this.pnMemberMenu.Visible = false;
            // 
            // btnMemberCenter
            // 
            this.btnMemberCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMemberCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberCenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMemberCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMemberCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberCenter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberCenter.ForeColor = System.Drawing.Color.White;
            this.btnMemberCenter.Location = new System.Drawing.Point(0, 0);
            this.btnMemberCenter.Name = "btnMemberCenter";
            this.btnMemberCenter.Size = new System.Drawing.Size(124, 31);
            this.btnMemberCenter.TabIndex = 5;
            this.btnMemberCenter.Text = "會員中心";
            this.btnMemberCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberCenter.UseVisualStyleBackColor = false;
            this.btnMemberCenter.Click += new System.EventHandler(this.btnMemberCenter_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(905, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 24);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 612);
            this.Controls.Add(this.pnMemberMenu);
            this.Controls.Add(this.sCBig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜單";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.sCBig.Panel1.ResumeLayout(false);
            this.sCBig.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCBig)).EndInit();
            this.sCBig.ResumeLayout(false);
            this.pnMemberMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMemberCenter;
        public System.Windows.Forms.Panel pnMemberMenu;
        private System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblLauncher;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.SplitContainer sCBig;
        private System.Windows.Forms.Button btnSwitchRole;
        public System.Windows.Forms.Button btnMin;
    }
}

