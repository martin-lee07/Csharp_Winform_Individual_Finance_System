namespace 个人理财
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.收支管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.基本资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddExp = new System.Windows.Forms.ToolStripButton();
            this.tsbStatistics = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddItems = new System.Windows.Forms.ToolStripButton();
            this.tsbtsmUser = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssMsg = new System.Windows.Forms.ToolStripLabel();
            this.tsmItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.收支管理ToolStripMenuItem,
            this.基本资料ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit,
            this.tsmLogout});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(181, 26);
            this.tsmExit.Text = "退出(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(181, 26);
            this.tsmLogout.Text = "注销(&Z)";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // 收支管理ToolStripMenuItem
            // 
            this.收支管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExp,
            this.tsmStatistics});
            this.收支管理ToolStripMenuItem.Name = "收支管理ToolStripMenuItem";
            this.收支管理ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.收支管理ToolStripMenuItem.Text = "收支管理(&E)";
            // 
            // tsmAddExp
            // 
            this.tsmAddExp.Name = "tsmAddExp";
            this.tsmAddExp.Size = new System.Drawing.Size(181, 26);
            this.tsmAddExp.Text = "添加收支(&P)";
            this.tsmAddExp.Click += new System.EventHandler(this.tsmAddExp_Click);
            // 
            // tsmStatistics
            // 
            this.tsmStatistics.Name = "tsmStatistics";
            this.tsmStatistics.Size = new System.Drawing.Size(181, 26);
            this.tsmStatistics.Text = "统计查询(&C)";
            this.tsmStatistics.Click += new System.EventHandler(this.tsmStatistics_Click);
            // 
            // 基本资料ToolStripMenuItem
            // 
            this.基本资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItems,
            this.toolStripSeparator3,
            this.tsmAddItems,
            this.tsmUser});
            this.基本资料ToolStripMenuItem.Name = "基本资料ToolStripMenuItem";
            this.基本资料ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.基本资料ToolStripMenuItem.Text = "基本资料(&D)";
            // 
            // tsmAddItems
            // 
            this.tsmAddItems.Name = "tsmAddItems";
            this.tsmAddItems.Size = new System.Drawing.Size(188, 26);
            this.tsmAddItems.Text = "添加收支项目(&I)";
            this.tsmAddItems.Click += new System.EventHandler(this.tsmAddItems_Click);
            // 
            // tsmUser
            // 
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(188, 26);
            this.tsmUser.Text = "用户管理(&U)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(181, 26);
            this.tsmAbout.Text = "关于(&A)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddExp,
            this.tsbStatistics,
            this.toolStripSeparator1,
            this.tsbAddItems,
            this.tsbtsmUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbAddExp
            // 
            this.tsbAddExp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddExp.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddExp.Image")));
            this.tsbAddExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddExp.Name = "tsbAddExp";
            this.tsbAddExp.Size = new System.Drawing.Size(36, 36);
            this.tsbAddExp.Text = "toolStripButton1";
            this.tsbAddExp.ToolTipText = "记录收支情况";
            this.tsbAddExp.Click += new System.EventHandler(this.tsmAddExp_Click);
            // 
            // tsbStatistics
            // 
            this.tsbStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsbStatistics.Image")));
            this.tsbStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatistics.Name = "tsbStatistics";
            this.tsbStatistics.Size = new System.Drawing.Size(36, 36);
            this.tsbStatistics.Text = "toolStripButton4";
            this.tsbStatistics.ToolTipText = "收支统计和查询";
            this.tsbStatistics.Click += new System.EventHandler(this.tsmStatistics_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAddItems
            // 
            this.tsbAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddItems.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddItems.Image")));
            this.tsbAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddItems.Name = "tsbAddItems";
            this.tsbAddItems.Size = new System.Drawing.Size(36, 36);
            this.tsbAddItems.Text = "toolStripButton5";
            this.tsbAddItems.ToolTipText = "添加收支项目类别";
            this.tsbAddItems.Click += new System.EventHandler(this.tsmAddItems_Click);
            // 
            // tsbtsmUser
            // 
            this.tsbtsmUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtsmUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtsmUser.Image")));
            this.tsbtsmUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtsmUser.Name = "tsbtsmUser";
            this.tsbtsmUser.Size = new System.Drawing.Size(36, 36);
            this.tsbtsmUser.Text = "用户信息管理";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.toolStripSeparator2,
            this.tssMsg});
            this.toolStrip2.Location = new System.Drawing.Point(0, 692);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(964, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tssStatus
            // 
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 22);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tssMsg
            // 
            this.tssMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(114, 22);
            this.tssMsg.Text = "请选择一个操作";
            this.tssMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmItems
            // 
            this.tsmItems.Name = "tsmItems";
            this.tsmItems.Size = new System.Drawing.Size(188, 26);
            this.tsmItems.Text = "收支项目管理";
            this.tsmItems.Click += new System.EventHandler(this.tsmItems_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 717);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "个人理财";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmAddExp;
        private System.Windows.Forms.ToolStripMenuItem tsmStatistics;
        private System.Windows.Forms.ToolStripMenuItem tsmAddItems;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddExp;
        private System.Windows.Forms.ToolStripButton tsbStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddItems;
        private System.Windows.Forms.ToolStripButton tsbtsmUser;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tssStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tssMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}