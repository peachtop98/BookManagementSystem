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

namespace _1.BookManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new RegisterForm().Show();//显示注册窗体
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = School; User ID = sa; Password = 123456";
            try
            {
                string User = tbUserName.Text;
                string Pwd = tbPassword.Text;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                                 //SqlCommand comm = conn.CreateCommand();
                                 //comm.CommandText = "select * from Userinfo where name = '" + User +"'";
                                 //SqlDataReader reader = comm.ExecuteReader();

                    string sql = "select id,password from Userinfo where name='{0}'";
                    sql = string.Format(sql, tbUserName.Text); //填充 SQL 语句
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader(); //执行 SQL 语句;
                                                                //cmd.ExecuteReader()返回的是SqlReader对象

                    if (reader.Read())  //判断是否读取到信息
                    {
                        string password =reader.GetString(reader.GetOrdinal("Password"));
                        if (Pwd == password)
                        {
                            MessageBox.Show("登录成功！ ");
                            //this.Hide(); //隐藏当前窗体
                            //new MainMenuForm().Show();//开启主菜单窗体
                        }
                        else
                        {
                            MessageBox.Show("密码错误！ ");
                            tbUserName.Text = " ";
                            tbPassword.Text = " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户不存在！ ");
                        tbUserName.Text = " ";
                        tbPassword.Text = " ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }






    }
}
