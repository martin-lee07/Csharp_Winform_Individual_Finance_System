using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 个人理财
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult exitresult = MessageBox.Show("确认退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exitresult == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void tsmAddExp_Click(object sender, EventArgs e)
        {
            AddExpenditure AddExpFrm = new AddExpenditure();
            AddExpFrm.MdiParent = this;
            AddExpFrm.Show();
            tssMsg.Text = AddExpFrm.Text;
        }

        private void tsmAddItems_Click(object sender, EventArgs e)
        {
            AddItems AddItemsFrm = new AddItems();
            AddItemsFrm.MdiParent = this;
            AddItemsFrm.Show();
            tssMsg.Text = AddItemsFrm.Text;
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutFrm = new AboutForm();
            aboutFrm.MdiParent = this;
            aboutFrm.Show();
            tssMsg.Text = aboutFrm.Text;
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsmStatistics_Click(object sender, EventArgs e)
        {
            SelectList SelectListFrm = new SelectList();
            SelectListFrm.MdiParent = this;
            SelectListFrm.Show();
            tssMsg.Text = SelectListFrm.Text;

        }

        private void tsmItems_Click(object sender, EventArgs e)
        {
            UpdateItems UpdateItemsFrm = new UpdateItems();
            UpdateItemsFrm.MdiParent = this;
            UpdateItemsFrm.Show();
            tssMsg.Text = UpdateItemsFrm.Text;

        }
    }
}
