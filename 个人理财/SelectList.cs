using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 个人理财
{
    public partial class SelectList : Form
    {
        string connString = @"Data Source = .; Initial Catalog = finance3; user ID = sa; Pwd = 123456";
        SqlConnection conn;
        public SelectList()
        {
            InitializeComponent();
        }

        private void cboKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            txtValue1.Text = txtValue2.Text = "";
            if (key == "金额" || key == "日期")
                txtValue2.Enabled = true;
            else
                txtValue2.Enabled = false;
        }

        private void SelectList_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            cboKey.Items.Add("收支项");
            cboKey.Items.Add("类别");
            cboKey.Items.Add("说明");
            cboKey.Items.Add("金额");
            cboKey.Items.Add("日期");

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            string value1 = txtValue1.Text.Trim();
            string condition = "";
            if (value1 == "")
            {
                MessageBox.Show("请输入用户名！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (key)
                {
                    case "收支项":
                        condition = String.Format("and c.itemname like '%{0}%'", value1); break;
                    case "类别":
                        condition = String.Format("and b.categoryname like '%{0}%'", value1); break;
                    case "说明":
                        condition = String.Format("and a.explain like '%{0}%'", value1); break;
                    case "金额":
                        condition = String.Format("and a.jine between '{0}' and '{1}'", value1, txtValue2.Text.Trim()); break;
                    case "日期":
                        condition = String.Format("and a.tradedate between '{0}' and '{1}'", value1, txtValue2.Text.Trim()); break;
                }
                string sql = "select a.listid as ID,c.itemname as 收支项,b.CategoryName as 类别," + " b.ispayout as 是否支出,a.tradedate as 收支日期,a.jine as 金额,a.explain as 说明" + " from list as a,category as b,item as c where a.itemid = c.itemid and c.categoryid = b.categoryid " + condition;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvList.DataSource = ds.Tables[0];
            }
        }
    }
}
