namespace Solo
{
    partial class UCSeat
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
            this.btnSeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeat
            // 
            this.btnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeat.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSeat.Location = new System.Drawing.Point(0, 19);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Size = new System.Drawing.Size(73, 60);
            this.btnSeat.TabIndex = 0;
            this.btnSeat.Text = "1";
            this.btnSeat.UseVisualStyleBackColor = false;
            this.btnSeat.Click += new System.EventHandler(this.btnSeat_Click);
            // 
            // UCSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnSeat);
            this.Name = "UCSeat";
            this.Size = new System.Drawing.Size(73, 100);
            this.Load += new System.EventHandler(this.UCSeat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSeat;
    }
}
