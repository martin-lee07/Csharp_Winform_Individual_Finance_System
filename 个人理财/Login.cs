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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text.Trim();
            string Password = txtPwd.Text.Trim();
            if(userName == "")
            {
                MessageBox.Show("请输入用户名！","登陆失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtName.Clear();
                if(Password == "")
                {
                    MessageBox.Show("请输入密码！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPwd.Clear();
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = finance3;user ID = sa;Pwd = 123456");
                    string sql = String.Format("select count(*) from users where username = '{0}' and password = '{1}' and status = '1'", userName, Password);
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int num = (int)comm.ExecuteScalar();
                        if (num == 1)
                        {
                            string loginsuccess = string.Format("UPDATE users SET errornum = '0' WHERE username ='{0}'", userName);
                            SqlCommand clearerrornumber = new SqlCommand(loginsuccess, conn);
                            int q1 = clearerrornumber.ExecuteNonQuery();
                            MessageBox.Show("欢迎进入理财系统！", "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainFrm mainform = new MainFrm();
                            mainform.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            string selecttimes = string.Format("select errornum from users WHERE username ='{0}'", userName);
                            SqlCommand errortimes = new SqlCommand(selecttimes, conn);
                            int errortime = (int)errortimes.ExecuteScalar();
                            if (errortime < 3)
                            {
                                txtPwd.Text = "";
                                string loginfailed = string.Format("UPDATE users SET errornum = errornum +1 WHERE username ='{0}'", userName);
                                SqlCommand errornumber = new SqlCommand(loginfailed, conn);
                                int q = errornumber.ExecuteNonQuery();
                                string errormessagebox = String.Format("您输入的用户名或密码错误,错误次数 {0} 次，连续错误3次将锁定账户!", errortime + 1);
                                MessageBox.Show(errormessagebox, "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                txtPwd.Text = "";
                                string lockuser = string.Format("UPDATE users SET status = '0' WHERE username ='{0}'", userName);
                                SqlCommand lockeduser = new SqlCommand(lockuser, conn);
                                int q = lockeduser.ExecuteNonQuery();
                                MessageBox.Show("您的帐户已被锁定，联系管理员解锁！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = finance3;user ID = sa;Pwd = 123456");
                string sql = String.Format("select count(*) from users where username = '{0}' and password = '{1}' and status = '1'", userName, Password);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = (int)comm.ExecuteScalar();
                    if (num == 1)
                    {
                        string loginsuccess = string.Format("UPDATE users SET errornum = '0' WHERE username ='{0}'", userName);
                        SqlCommand clearerrornumber = new SqlCommand(loginsuccess, conn);
                        int q2 = clearerrornumber.ExecuteNonQuery();
                        MessageBox.Show("欢迎进入理财系统！", "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainFrm mainform = new MainFrm();
                        mainform.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        string selecttimes = string.Format("select errornum from users WHERE username ='{0}'", userName);
                        SqlCommand errortimes = new SqlCommand(selecttimes, conn);
                        int errortime = (int)errortimes.ExecuteScalar();
                        if (errortime < 3)
                        {
                            txtPwd.Text = "";
                            string loginfailed = string.Format("UPDATE users SET errornum = errornum +1 WHERE username ='{0}'", userName);
                            SqlCommand errornumber = new SqlCommand(loginfailed, conn);
                            int q = errornumber.ExecuteNonQuery();
                            string errormessagebox = String.Format("您输入的用户名或密码错误,错误次数 {0} 次，连续错误3次将锁定账户!", errortime + 1);
                            MessageBox.Show(errormessagebox, "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            txtPwd.Text = "";
                            string lockuser = string.Format("UPDATE users SET status = '0' WHERE username ='{0}'", userName);
                            SqlCommand lockeduser = new SqlCommand(lockuser, conn);
                            int q = lockeduser.ExecuteNonQuery();
                            MessageBox.Show("您的帐户已被锁定，联系管理员解锁！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitresult = MessageBox.Show("确认退出？", "退出",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(exitresult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
