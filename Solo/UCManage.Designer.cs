namespace Solo
{
    partial class UCManage
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
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblEmployeeManage = new System.Windows.Forms.Label();
            this.lblGoodsManage = new System.Windows.Forms.Label();
            this.lblMemberManage = new System.Windows.Forms.Label();
            this.lblOrderManage = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.flpManage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cbxColumn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel1.Controls.Add(this.lblHistory);
            this.splitContainer1.Panel1.Controls.Add(this.lblProfit);
            this.splitContainer1.Panel1.Controls.Add(this.lblGoodsManage);
            this.splitContainer1.Panel1.Controls.Add(this.lblMemberManage);
            this.splitContainer1.Panel1.Controls.Add(this.lblOrderManage);
            this.splitContainer1.Panel1.Controls.Add(this.lblSeat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.flpManage);
            this.splitContainer1.Panel2.Controls.Add(this.lblEmployeeManage);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.txtKeyword);
            this.splitContainer1.Panel2.Controls.Add(this.cbxColumn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainer1.Size = new System.Drawing.Size(930, 535);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblProfit
            // 
            this.lblProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProfit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProfit.ForeColor = System.Drawing.Color.White;
            this.lblProfit.Location = new System.Drawing.Point(7, 437);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(120, 85);
            this.lblProfit.TabIndex = 11;
            this.lblProfit.Text = "上月收益";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfit.Visible = false;
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // lblEmployeeManage
            // 
            this.lblEmployeeManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEmployeeManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeeManage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmployeeManage.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeManage.Location = new System.Drawing.Point(19, 15);
            this.lblEmployeeManage.Name = "lblEmployeeManage";
            this.lblEmployeeManage.Size = new System.Drawing.Size(82, 42);
            this.lblEmployeeManage.TabIndex = 10;
            this.lblEmployeeManage.Text = "員工管理";
            this.lblEmployeeManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmployeeManage.Visible = false;
            this.lblEmployeeManage.Click += new System.EventHandler(this.lblEmployeeManage_Click);
            // 
            // lblGoodsManage
            // 
            this.lblGoodsManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblGoodsManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoodsManage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGoodsManage.ForeColor = System.Drawing.Color.White;
            this.lblGoodsManage.Location = new System.Drawing.Point(7, 267);
            this.lblGoodsManage.Name = "lblGoodsManage";
            this.lblGoodsManage.Size = new System.Drawing.Size(120, 85);
            this.lblGoodsManage.TabIndex = 9;
            this.lblGoodsManage.Text = "商品管理";
            this.lblGoodsManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoodsManage.Click += new System.EventHandler(this.lblGoodsManage_Click);
            // 
            // lblMemberManage
            // 
            this.lblMemberManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMemberManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemberManage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMemberManage.ForeColor = System.Drawing.Color.White;
            this.lblMemberManage.Location = new System.Drawing.Point(7, 182);
            this.lblMemberManage.Name = "lblMemberManage";
            this.lblMemberManage.Size = new System.Drawing.Size(120, 85);
            this.lblMemberManage.TabIndex = 8;
            this.lblMemberManage.Text = "會員管理";
            this.lblMemberManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMemberManage.Click += new System.EventHandler(this.lblMemberManage_Click);
            // 
            // lblOrderManage
            // 
            this.lblOrderManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblOrderManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderManage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderManage.ForeColor = System.Drawing.Color.White;
            this.lblOrderManage.Location = new System.Drawing.Point(7, 97);
            this.lblOrderManage.Name = "lblOrderManage";
            this.lblOrderManage.Size = new System.Drawing.Size(120, 85);
            this.lblOrderManage.TabIndex = 7;
            this.lblOrderManage.Text = "訂單管理";
            this.lblOrderManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderManage.Click += new System.EventHandler(this.lblOrderManage_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeat.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSeat.ForeColor = System.Drawing.Color.White;
            this.lblSeat.Location = new System.Drawing.Point(7, 12);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(120, 85);
            this.lblSeat.TabIndex = 6;
            this.lblSeat.Text = "座位狀況";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat.Click += new System.EventHandler(this.lblSeat_Click);
            // 
            // flpManage
            // 
            this.flpManage.AutoScroll = true;
            this.flpManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flpManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpManage.Location = new System.Drawing.Point(0, 65);
            this.flpManage.Name = "flpManage";
            this.flpManage.Size = new System.Drawing.Size(793, 470);
            this.flpManage.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(502, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyword.Location = new System.Drawing.Point(357, 20);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(139, 33);
            this.txtKeyword.TabIndex = 4;
            // 
            // cbxColumn
            // 
            this.cbxColumn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxColumn.FormattingEnabled = true;
            this.cbxColumn.Location = new System.Drawing.Point(230, 20);
            this.cbxColumn.Name = "cbxColumn";
            this.cbxColumn.Size = new System.Drawing.Size(121, 32);
            this.cbxColumn.TabIndex = 3;
            this.cbxColumn.Text = "欄位選擇";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "關鍵字搜尋";
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(644, 11);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 46);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "新增";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHistory.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHistory.ForeColor = System.Drawing.Color.White;
            this.lblHistory.Location = new System.Drawing.Point(7, 352);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(120, 85);
            this.lblHistory.TabIndex = 12;
            this.lblHistory.Text = "使用紀錄";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // UCManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCManage";
            this.Size = new System.Drawing.Size(930, 535);
            this.Load += new System.EventHandler(this.UCManage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblEmployeeManage;
        private System.Windows.Forms.Label lblGoodsManage;
        private System.Windows.Forms.Label lblMemberManage;
        private System.Windows.Forms.Label lblOrderManage;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.FlowLayoutPanel flpManage;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cbxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHistory;
    }
}
