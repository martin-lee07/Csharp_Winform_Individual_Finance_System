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
    public partial class AddExpenditure : Form
    {
        string connString = @"Data Source = .; Initial Catalog = finance3; user ID = sa; Pwd = 123456";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        class Item
        {
            public int IId;
            public string IName;
            public Item(int id, string name)
            {
                IId = id;
                IName = name;
            }
            public override string ToString()
            {
                return IName;
            }
        }
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

        public AddExpenditure()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdoIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdotExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            string sql = "select * from category where ispayout=1";
            if (rdotExpenditure.Checked == true)
            {
                sql = "select * from category where ispayout=1";
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        int iId = (int)dr[0];
                        string name = dr["CategoryName"].ToString().Trim();
                        cboCategory.Items.Add(new Item(iId, name));
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
                sql = "select * from category where ispayout=0";
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        int iId = (int)dr[0];
                        string name = dr["CategoryName"].ToString().Trim();
                        cboCategory.Items.Add(new Item(iId, name));
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

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItem.Items.Clear();
            int cId = 0;
            string category = cboCategory.SelectedItem.ToString();
            string searchcategory = String.Format("select categoryid from category where categoryname = '{0}'", category);
            conn.Open();
            SqlCommand categorysearched = new SqlCommand(searchcategory, conn);
            cId = (int)categorysearched.ExecuteScalar();
            conn.Close();
            //category.CName = (string)cboCategory.SelectedItem;
            //if (category != null) cId = category.CId;
            string ItemIn = String.Format("select * from item where categoryid = '{0}'", cId);
            try
            {
                conn.Open();
                comm.CommandText = ItemIn;
                dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    int iId = (int)dr[0];
                    string name = dr["itemname"].ToString().Trim();
                    lstItem.Items.Add(new Item(iId, name));
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iId = 0;
            string item = lstItem.SelectedItem.ToString();
            string searchcategory = String.Format("select itemid from item where itemname = '{0}'", item);
            conn.Open();
            SqlCommand categorysearched = new SqlCommand(searchcategory, conn);
            iId = (int)categorysearched.ExecuteScalar();
            conn.Close();

            //Item item = lstItem.SelectedItem as Item;
            //if (item != null) iId = item.IId;
            decimal amount = numAmount.Value;
            DateTime date = dtpDate.Value;
            string explain = txtExplain.Text;
            string sql = String.Format("insert into list(itemid,jine,tradedate,explain) values('{0}','{1}','{2}','{3}')", iId, amount, date, explain);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                int count = comm.ExecuteNonQuery();
                if(count>0)
                    MessageBox.Show("添加明细成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加明细失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
            rtxtRemarks.Clear();
            rtxtRemarks.AppendText("要保存的信息为：\n");
            rtxtRemarks.AppendText(cboCategory.SelectedItem.ToString());
            rtxtRemarks.AppendText("-");
            rtxtRemarks.AppendText(lstItem.SelectedItem.ToString());
            rtxtRemarks.AppendText("\n日期：");
            rtxtRemarks.AppendText(dtpDate.Value.ToLongDateString());
            rtxtRemarks.AppendText("\n说明：");
            rtxtRemarks.AppendText(txtExplain.Text);
            rtxtRemarks.AppendText("\n收支人：");
            if (chkOwn.Checked) rtxtRemarks.AppendText(chkOwn.Text);
            if (chkFamily.Checked) rtxtRemarks.AppendText("、" + chkFamily.Text);
            if (chkRelative.Checked) rtxtRemarks.AppendText("、" + chkRelative.Text);
            if (chkFamily.Checked) rtxtRemarks.AppendText("、" + chkFamily.Text);
            if (chkColleague.Checked) rtxtRemarks.AppendText("、" + chkColleague.Text);
            if (chkOther.Checked) rtxtRemarks.AppendText("、" + chkOther.Text);
            rtxtRemarks.AppendText("\n金额：");
            rtxtRemarks.AppendText(numAmount.Value.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExpenditure_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            rdoIncome.Checked = true;

        }
    }
}
