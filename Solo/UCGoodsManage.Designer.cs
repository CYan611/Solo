namespace Solo
{
    partial class UCGoodsManage
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
            this.lblChangePic = new System.Windows.Forms.Label();
            this.lblGoodsID = new System.Windows.Forms.Label();
            this.cbxGoodsClass = new System.Windows.Forms.ComboBox();
            this.txtGoodsAmount = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsPrice = new System.Windows.Forms.TextBox();
            this.lblSaveChange = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangePic
            // 
            this.lblChangePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblChangePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChangePic.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChangePic.ForeColor = System.Drawing.Color.White;
            this.lblChangePic.Location = new System.Drawing.Point(527, 1);
            this.lblChangePic.Margin = new System.Windows.Forms.Padding(0);
            this.lblChangePic.Name = "lblChangePic";
            this.lblChangePic.Size = new System.Drawing.Size(97, 30);
            this.lblChangePic.TabIndex = 22;
            this.lblChangePic.Text = "修改圖片";
            this.lblChangePic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChangePic.Click += new System.EventHandler(this.lblChangePic_Click);
            // 
            // lblGoodsID
            // 
            this.lblGoodsID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblGoodsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoodsID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGoodsID.ForeColor = System.Drawing.Color.White;
            this.lblGoodsID.Location = new System.Drawing.Point(23, 1);
            this.lblGoodsID.Name = "lblGoodsID";
            this.lblGoodsID.Size = new System.Drawing.Size(89, 30);
            this.lblGoodsID.TabIndex = 18;
            this.lblGoodsID.Text = "商品編號";
            this.lblGoodsID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxGoodsClass
            // 
            this.cbxGoodsClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxGoodsClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGoodsClass.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxGoodsClass.ForeColor = System.Drawing.Color.White;
            this.cbxGoodsClass.FormattingEnabled = true;
            this.cbxGoodsClass.Items.AddRange(new object[] {
            "dessert",
            "drink",
            "food"});
            this.cbxGoodsClass.Location = new System.Drawing.Point(413, 1);
            this.cbxGoodsClass.Name = "cbxGoodsClass";
            this.cbxGoodsClass.Size = new System.Drawing.Size(115, 30);
            this.cbxGoodsClass.Sorted = true;
            this.cbxGoodsClass.TabIndex = 23;
            this.cbxGoodsClass.Text = "商品分類";
            // 
            // txtGoodsAmount
            // 
            this.txtGoodsAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGoodsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGoodsAmount.ForeColor = System.Drawing.Color.White;
            this.txtGoodsAmount.Location = new System.Drawing.Point(111, 1);
            this.txtGoodsAmount.Multiline = true;
            this.txtGoodsAmount.Name = "txtGoodsAmount";
            this.txtGoodsAmount.Size = new System.Drawing.Size(61, 30);
            this.txtGoodsAmount.TabIndex = 24;
            this.txtGoodsAmount.Text = "庫存";
            this.txtGoodsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGoodsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGoodsName.ForeColor = System.Drawing.Color.White;
            this.txtGoodsName.Location = new System.Drawing.Point(171, 1);
            this.txtGoodsName.Multiline = true;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(151, 30);
            this.txtGoodsName.TabIndex = 25;
            this.txtGoodsName.Text = "商品名稱";
            this.txtGoodsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGoodsPrice
            // 
            this.txtGoodsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGoodsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGoodsPrice.ForeColor = System.Drawing.Color.White;
            this.txtGoodsPrice.Location = new System.Drawing.Point(321, 1);
            this.txtGoodsPrice.Multiline = true;
            this.txtGoodsPrice.Name = "txtGoodsPrice";
            this.txtGoodsPrice.Size = new System.Drawing.Size(93, 30);
            this.txtGoodsPrice.TabIndex = 26;
            this.txtGoodsPrice.Text = "商品價格";
            this.txtGoodsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaveChange
            // 
            this.lblSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSaveChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaveChange.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSaveChange.ForeColor = System.Drawing.Color.White;
            this.lblSaveChange.Location = new System.Drawing.Point(623, 1);
            this.lblSaveChange.Margin = new System.Windows.Forms.Padding(0);
            this.lblSaveChange.Name = "lblSaveChange";
            this.lblSaveChange.Size = new System.Drawing.Size(97, 30);
            this.lblSaveChange.TabIndex = 27;
            this.lblSaveChange.Text = "儲存修改";
            this.lblSaveChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveChange.Click += new System.EventHandler(this.lblSaveChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Solo.Properties.Resources.redX1;
            this.btnDelete.Location = new System.Drawing.Point(724, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCGoodsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSaveChange);
            this.Controls.Add(this.txtGoodsPrice);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsAmount);
            this.Controls.Add(this.cbxGoodsClass);
            this.Controls.Add(this.lblChangePic);
            this.Controls.Add(this.lblGoodsID);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCGoodsManage";
            this.Size = new System.Drawing.Size(770, 32);
            this.Load += new System.EventHandler(this.UCGoodsManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblChangePic;
        public System.Windows.Forms.Label lblGoodsID;
        public System.Windows.Forms.Label lblSaveChange;
        public System.Windows.Forms.TextBox txtGoodsName;
        public System.Windows.Forms.TextBox txtGoodsPrice;
        public System.Windows.Forms.ComboBox cbxGoodsClass;
        public System.Windows.Forms.TextBox txtGoodsAmount;
        public System.Windows.Forms.Button btnDelete;
    }
}
