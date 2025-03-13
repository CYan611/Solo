namespace Solo
{
    partial class UCCart
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.Location = new System.Drawing.Point(331, 464);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(126, 44);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "全部清除";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.Location = new System.Drawing.Point(633, 464);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(126, 44);
            this.btnSendOrder.TabIndex = 1;
            this.btnSendOrder.Text = "送出訂單";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturnMenu.Location = new System.Drawing.Point(28, 464);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(126, 44);
            this.btnReturnMenu.TabIndex = 2;
            this.btnReturnMenu.Text = "繼續選購";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(793, 458);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnClearAll);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(793, 535);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
