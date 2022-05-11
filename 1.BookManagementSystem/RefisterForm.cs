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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRedister_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = BookDB; User ID = sa; Password = 123456";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    if (tbUserName.Text == null || tbUserName.Text.Length== 0 || tbUserName.Text == " ")
                    {//判断输入的数据不能为空
                        MessageBox.Show("请输入用户名！ ");
                        return;
                    }
                 if(tbPassword.Text == null || tbPassword.Text.Length== 0 || tbPassword.Text == " ")
                {//判断输入的数据是否为空
                        MessageBox.Show("请输入密码！ ");
                        return;
                    }
                    string sql = "insert into BookDB(UserName, Password)values('{0}', '{1}')";
                    sql = string.Format(sql, tbUserName.Text,tbPassword.Text);//填充 SQL 语句
                    //创建 SqlCommand 对象
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int returnvalue = cmd.ExecuteNonQuery();//执行 SQL 语句
                    if (returnvalue != -1)
                    { //判断 SQL 语句是否执行成功
                        MessageBox.Show("注册成功！ ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！ ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败！ " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
