namespace Solo
{
    partial class UCOrderList
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
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblGoodsPrice = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoodsName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGoodsName.ForeColor = System.Drawing.Color.White;
            this.lblGoodsName.Location = new System.Drawing.Point(24, 1);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(194, 30);
            this.lblGoodsName.TabIndex = 1;
            this.lblGoodsName.Text = "商品名稱";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoodsPrice
            // 
            this.lblGoodsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoodsPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGoodsPrice.ForeColor = System.Drawing.Color.White;
            this.lblGoodsPrice.Location = new System.Drawing.Point(215, 1);
            this.lblGoodsPrice.Name = "lblGoodsPrice";
            this.lblGoodsPrice.Size = new System.Drawing.Size(117, 30);
            this.lblGoodsPrice.TabIndex = 2;
            this.lblGoodsPrice.Text = "單價";
            this.lblGoodsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderAmount.ForeColor = System.Drawing.Color.White;
            this.lblOrderAmount.Location = new System.Drawing.Point(329, 1);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(117, 30);
            this.lblOrderAmount.TabIndex = 3;
            this.lblOrderAmount.Text = "數量";
            this.lblOrderAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderTime.ForeColor = System.Drawing.Color.White;
            this.lblOrderTime.Location = new System.Drawing.Point(445, 1);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(216, 30);
            this.lblOrderTime.TabIndex = 4;
            this.lblOrderTime.Text = "下單時間";
            this.lblOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(659, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "移除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(658, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "已送出";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderTime);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblGoodsPrice);
            this.Controls.Add(this.lblGoodsName);
            this.Name = "UCOrderList";
            this.Size = new System.Drawing.Size(770, 32);
            this.Load += new System.EventHandler(this.UCOrderList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblGoodsName;
        public System.Windows.Forms.Label lblGoodsPrice;
        public System.Windows.Forms.Label lblOrderAmount;
        public System.Windows.Forms.Label lblOrderTime;
        public System.Windows.Forms.Label label1;
    }
}
