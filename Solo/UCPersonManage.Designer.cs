namespace Solo
{
    partial class UCPersonManage
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
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetail.ForeColor = System.Drawing.Color.White;
            this.lblDetail.Location = new System.Drawing.Point(653, 1);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(108, 30);
            this.lblDetail.TabIndex = 27;
            this.lblDetail.Text = "編輯資料";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetail.Click += new System.EventHandler(this.lblDetail_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPersonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPersonID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(9, 1);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(115, 30);
            this.lblPersonID.TabIndex = 26;
            this.lblPersonID.Text = "會員編號";
            this.lblPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirth
            // 
            this.lblBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBirth.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBirth.ForeColor = System.Drawing.Color.White;
            this.lblBirth.Location = new System.Drawing.Point(507, 1);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(149, 30);
            this.lblBirth.TabIndex = 25;
            this.lblBirth.Text = "生日";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(237, 1);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(272, 30);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "電話";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(123, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 30);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "會員姓名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPersonManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "UCPersonManage";
            this.Size = new System.Drawing.Size(770, 32);
            this.Load += new System.EventHandler(this.UCPersonManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.Label lblPersonID;
        public System.Windows.Forms.Label lblBirth;
        public System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Label lblName;
    }
}
