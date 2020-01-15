namespace 个人理财
{
    partial class AddExpenditure
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.rdotExpenditure = new System.Windows.Forms.RadioButton();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkOwn = new System.Windows.Forms.CheckBox();
            this.chkFamily = new System.Windows.Forms.CheckBox();
            this.chkRelative = new System.Windows.Forms.CheckBox();
            this.chkFriend = new System.Windows.Forms.CheckBox();
            this.chkColleague = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "收支类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "收支类别：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(108, 26);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(58, 19);
            this.rdoIncome.TabIndex = 2;
            this.rdoIncome.Text = "收入";
            this.rdoIncome.UseVisualStyleBackColor = true;
            this.rdoIncome.CheckedChanged += new System.EventHandler(this.rdoIncome_CheckedChanged);
            // 
            // rdotExpenditure
            // 
            this.rdotExpenditure.AutoSize = true;
            this.rdotExpenditure.Checked = true;
            this.rdotExpenditure.Location = new System.Drawing.Point(172, 26);
            this.rdotExpenditure.Name = "rdotExpenditure";
            this.rdotExpenditure.Size = new System.Drawing.Size(58, 19);
            this.rdotExpenditure.TabIndex = 3;
            this.rdotExpenditure.TabStop = true;
            this.rdotExpenditure.Text = "支出";
            this.rdotExpenditure.UseVisualStyleBackColor = true;
            this.rdotExpenditure.CheckedChanged += new System.EventHandler(this.rdotExpenditure_CheckedChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(108, 57);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 23);
            this.cboCategory.TabIndex = 4;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "收支项目：";
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.ItemHeight = 15;
            this.lstItem.Items.AddRange(new object[] {
            "生活消费",
            "固定资产",
            "休闲娱乐",
            "医疗药品",
            "教育培训",
            "其他支出"});
            this.lstItem.Location = new System.Drawing.Point(108, 95);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(120, 94);
            this.lstItem.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(398, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 25);
            this.dtpDate.TabIndex = 7;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(398, 60);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(200, 25);
            this.txtExplain.TabIndex = 8;
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(108, 195);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(490, 96);
            this.rtxtRemarks.TabIndex = 9;
            this.rtxtRemarks.Text = "";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(398, 164);
            this.numAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(200, 25);
            this.numAmount.TabIndex = 10;
            this.numAmount.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存(&C)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkOwn
            // 
            this.chkOwn.AutoSize = true;
            this.chkOwn.Location = new System.Drawing.Point(398, 95);
            this.chkOwn.Name = "chkOwn";
            this.chkOwn.Size = new System.Drawing.Size(44, 19);
            this.chkOwn.TabIndex = 13;
            this.chkOwn.Text = "我";
            this.chkOwn.UseVisualStyleBackColor = true;
            // 
            // chkFamily
            // 
            this.chkFamily.AutoSize = true;
            this.chkFamily.Location = new System.Drawing.Point(464, 95);
            this.chkFamily.Name = "chkFamily";
            this.chkFamily.Size = new System.Drawing.Size(59, 19);
            this.chkFamily.TabIndex = 14;
            this.chkFamily.Text = "家人";
            this.chkFamily.UseVisualStyleBackColor = true;
            // 
            // chkRelative
            // 
            this.chkRelative.AutoSize = true;
            this.chkRelative.Location = new System.Drawing.Point(530, 95);
            this.chkRelative.Name = "chkRelative";
            this.chkRelative.Size = new System.Drawing.Size(59, 19);
            this.chkRelative.TabIndex = 15;
            this.chkRelative.Text = "亲戚";
            this.chkRelative.UseVisualStyleBackColor = true;
            // 
            // chkFriend
            // 
            this.chkFriend.AutoSize = true;
            this.chkFriend.Location = new System.Drawing.Point(398, 121);
            this.chkFriend.Name = "chkFriend";
            this.chkFriend.Size = new System.Drawing.Size(59, 19);
            this.chkFriend.TabIndex = 16;
            this.chkFriend.Text = "朋友";
            this.chkFriend.UseVisualStyleBackColor = true;
            // 
            // chkColleague
            // 
            this.chkColleague.AutoSize = true;
            this.chkColleague.Location = new System.Drawing.Point(464, 121);
            this.chkColleague.Name = "chkColleague";
            this.chkColleague.Size = new System.Drawing.Size(59, 19);
            this.chkColleague.TabIndex = 17;
            this.chkColleague.Text = "同事";
            this.chkColleague.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(530, 121);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(59, 19);
            this.chkOther.TabIndex = 18;
            this.chkOther.Text = "其他";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "说明：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "收支人：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "金额：";
            // 
            // AddExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkColleague);
            this.Controls.Add(this.chkFriend);
            this.Controls.Add(this.chkRelative);
            this.Controls.Add(this.chkFamily);
            this.Controls.Add(this.chkOwn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.rtxtRemarks);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.rdotExpenditure);
            this.Controls.Add(this.rdoIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddExpenditure";
            this.Text = "收支情况记录";
            this.Load += new System.EventHandler(this.AddExpenditure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.RadioButton rdotExpenditure;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkOwn;
        private System.Windows.Forms.CheckBox chkFamily;
        private System.Windows.Forms.CheckBox chkRelative;
        private System.Windows.Forms.CheckBox chkFriend;
        private System.Windows.Forms.CheckBox chkColleague;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}