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
    public partial class UpdateItems : Form
    {
        string connString = @"Data Source = .; Initial Catalog = finance3; user ID = sa; Pwd = 123456";
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            conn = new SqlConnection(connString);
            string sql = "select * from category";
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(ds);
            dgvItemsList.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult exitresult = MessageBox.Show("确认修改？", "修改提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exitresult == DialogResult.OK)
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                try
                {
                    da.Update(ds);
                    dgvItemsList.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                DataTable dt = dgvItemsList.DataSource as DataTable;
                dt.Rows.Clear();
                dgvItemsList.DataSource = dt;
                conn = new SqlConnection(connString);
                string sql = "select * from category";
                da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(ds);
                dgvItemsList.DataSource = ds.Tables[0];
            }
            else
            {
                /*dgvItemsList.Rows.Clear();
                conn = new SqlConnection(connString);
                string sql = "select * from category";
                da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(ds);
                dgvItemsList.DataSource = ds.Tables[0];
                conn.Close();*/

                DataTable dt = dgvItemsList.DataSource as DataTable;
                dt.Rows.Clear();
                dgvItemsList.DataSource = dt;
                conn = new SqlConnection(connString);
                string sql = "select * from category";
                da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(ds);
                dgvItemsList.DataSource = ds.Tables[0];

            }
        }

        private void dgvItemsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void dgvItemsList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int iCount = dgvItemsList.SelectedRows.Count;
            if (DialogResult.Yes == MessageBox.Show("是否删除？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                int selectedcategoryid = dgvItemsList.CurrentRow.Index;
                int categoryid = Convert.ToInt32(dgvItemsList.Rows[selectedcategoryid].Cells[0].Value.ToString());
                conn = new SqlConnection(connString);
                conn.Open();
                string searchcategoryid = String.Format("select * from item where categoryid = '{0}'", categoryid);
                SqlCommand search = new SqlCommand(searchcategoryid, conn);
                //string id = search.ExecuteScalar().ToString();
                if (search.ExecuteScalar() != null)
                    MessageBox.Show("有收支项目信息不能删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    for (int i = 0; i < dgvItemsList.Rows.Count - 1; i++)  //循环遍历所有行
                    {
                        if (dgvItemsList.Rows[i].Selected == true)
                            dgvItemsList.Rows.RemoveAt(i);
                    }
                    if (DialogResult.OK == MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        conn = new SqlConnection(connString);
                        conn.Open();
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        try
                        {
                            da.Update(ds);
                            dgvItemsList.DataSource = ds.Tables[0];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        DataTable dt = dgvItemsList.DataSource as DataTable;
                        dt.Rows.Clear();
                        dgvItemsList.DataSource = dt;
                        conn = new SqlConnection(connString);
                        string sql = "select * from category";
                        da = new SqlDataAdapter(sql, conn);
                        conn.Open();
                        da.Fill(ds);
                        dgvItemsList.DataSource = ds.Tables[0];
                    }
                }                
            }
        }
    }
}
