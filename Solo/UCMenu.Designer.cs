namespace Solo
{
    partial class UCMenu
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCheckOrder = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel1.Controls.Add(this.lblCheckOrder);
            this.splitContainer1.Panel1.Controls.Add(this.lblDrink);
            this.splitContainer1.Panel1.Controls.Add(this.lblDessert);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckout);
            this.splitContainer1.Panel1.Controls.Add(this.lblFood);
            this.splitContainer1.Panel1.Controls.Add(this.lblHomePage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.flpMenu);
            this.splitContainer1.Panel2.Controls.Add(this.btnReturnMenu);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendOrder);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearAll);
            this.splitContainer1.Size = new System.Drawing.Size(930, 535);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblCheckOrder
            // 
            this.lblCheckOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCheckOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheckOrder.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckOrder.ForeColor = System.Drawing.Color.White;
            this.lblCheckOrder.Location = new System.Drawing.Point(7, 353);
            this.lblCheckOrder.Name = "lblCheckOrder";
            this.lblCheckOrder.Size = new System.Drawing.Size(120, 83);
            this.lblCheckOrder.TabIndex = 21;
            this.lblCheckOrder.Text = "查看訂單";
            this.lblCheckOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCheckOrder.Click += new System.EventHandler(this.lblCheckOrder_Click);
            // 
            // lblDrink
            // 
            this.lblDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrink.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink.ForeColor = System.Drawing.Color.White;
            this.lblDrink.Location = new System.Drawing.Point(7, 270);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(120, 83);
            this.lblDrink.TabIndex = 20;
            this.lblDrink.Text = "多樣飲品";
            this.lblDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDrink.Click += new System.EventHandler(this.lblDrink_Click);
            // 
            // lblDessert
            // 
            this.lblDessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDessert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDessert.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDessert.ForeColor = System.Drawing.Color.White;
            this.lblDessert.Location = new System.Drawing.Point(7, 187);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(120, 83);
            this.lblDessert.TabIndex = 19;
            this.lblDessert.Text = "各式點心";
            this.lblDessert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDessert.Click += new System.EventHandler(this.lblDessert_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(13, 467);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 42);
            this.btnCheckout.TabIndex = 18;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblFood
            // 
            this.lblFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFood.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFood.ForeColor = System.Drawing.Color.White;
            this.lblFood.Location = new System.Drawing.Point(7, 104);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(120, 83);
            this.lblFood.TabIndex = 17;
            this.lblFood.Text = "精緻餐點";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFood.Click += new System.EventHandler(this.lblFood_Click);
            // 
            // lblHomePage
            // 
            this.lblHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomePage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHomePage.ForeColor = System.Drawing.Color.White;
            this.lblHomePage.Location = new System.Drawing.Point(7, 21);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(120, 83);
            this.lblHomePage.TabIndex = 16;
            this.lblHomePage.Text = "首頁";
            this.lblHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHomePage.Click += new System.EventHandler(this.lblHomePage_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(793, 436);
            this.flpMenu.TabIndex = 0;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReturnMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturnMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnMenu.Location = new System.Drawing.Point(88, 465);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(126, 44);
            this.btnReturnMenu.TabIndex = 5;
            this.btnReturnMenu.Text = "繼續選購";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSendOrder.FlatAppearance.BorderSize = 0;
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.ForeColor = System.Drawing.Color.White;
            this.btnSendOrder.Location = new System.Drawing.Point(588, 465);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(126, 44);
            this.btnSendOrder.TabIndex = 4;
            this.btnSendOrder.Text = "送出訂單";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(338, 465);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(126, 44);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "全部清除";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(930, 535);
            this.Load += new System.EventHandler(this.UCMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCheckOrder;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnClearAll;
    }
}
