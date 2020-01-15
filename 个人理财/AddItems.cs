using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 个人理财
{
    public partial class AddItems : Form
    {
        string connString = @"Data Source = .; Initial Catalog = finance3; user ID = sa; Pwd = 123456";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        class Category
        {
            public int CId;
            public string CName;
            public Category(int id, string name)
            {
                CId = id;
                CName = name;
            }
            public override string ToString()
            {
                return CName;
            }
        }

        public AddItems()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdotExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("一级大类");
            string sql = "select * from category where ispayout=1";
            if (rdotExpenditure.Checked == true)
            {
                sql = "select * from category where ispayout=0";
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        int cId = (int)dr[0];
                        string name = dr["CategoryName"].ToString().Trim();
                        cboCategory.Items.Add(new Category(cId, name));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                sql = "select * from category where ispayout=1";
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        int cId = (int)dr[0];
                        string name = dr["CategoryName"].ToString().Trim();
                        cboCategory.Items.Add(new Category(cId, name));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
                cboCategory.SelectedIndex = 0;

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请填写收支名称", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int isPayout = rdotExpenditure.Checked ? 1 : 0;
            int cId = cboCategory.SelectedIndex;
            string CategoryIn = "";
            if(cId==0) CategoryIn = String.Format("insert into category(categoryname,ispayout) values('{0}','{1}')", name, isPayout);
            else
            {
                Category category = cboCategory.SelectedItem as Category;
                if(category!=null)
                {
                    cId = category.CId;
                    CategoryIn = String.Format("insert into item(itemname,categoryid) values('{0}','{1}')", name, cId);
                }
            }

            //string connString = "Data Source = .; Initial Catalog = finance3; user ID = sa; Pwd = 123456";
            //SqlConnection conn = new SqlConnection(connString);
            //string sql = String.Format("insert into category(categoryname,ispayout) values('{0}','{1}')", name, isPayout);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(CategoryIn, conn);
                int count = comm.ExecuteNonQuery();
                if (count > 0)
                    MessageBox.Show("添加类别成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加类别失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            //rdoIncome.Checked = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请填写收支名称！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    rtxtMsg.Clear();
                    rtxtMsg.AppendText("要添加的收支项目为：");
                    rtxtMsg.AppendText(txtName.Text);
                    rtxtMsg.AppendText("\n所属类别：");
                    rtxtMsg.AppendText(cboCategory.SelectedItem.ToString());
                    if (rdotExpenditure.Checked == true) rtxtMsg.AppendText("\n是支出类型的项目");
                    else rtxtMsg.AppendText("\n是收入类型的项目");
                }
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rdoIncome_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
