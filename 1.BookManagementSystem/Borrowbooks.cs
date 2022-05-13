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
    public partial class Borrowbooks : Form
    {
        string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = BookDB; User ID = sa; Password = 123456";
        public Borrowbooks()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "SELECT rdID 读者编号,bkID 书号,DateBorrow 借书日期,DateLendPlan 还书日期,rdtypename1 教师名字 FROM Borrow";
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgvRdCategory.DataSource = ds.Tables[0];
                    tbRdID.DataBindings.Clear();
                    tbBkID.DataBindings.Clear();
                    tbRdID.DataBindings.Add("Text", ds.Tables[0], "读者编号");//tbRdID,把得到的数据放入框框内
                    tbBkID.DataBindings.Add("Text", ds.Tables[0], "书号");//tbBkID，把得到的数据放入框框内

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }
        private void Borrowbooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//还书点击触发函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "exec usp_ReturnBook @rdID,@bkID";
                    comm.Parameters.AddWithValue("@rdID", tbRdID.Text);
                    comm.Parameters.AddWithValue("@bkID", tbBkID.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("还书成功！ ");
                    DataBind();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "还书失败！ ");
            }
        }

        private void button2_Click(object sender, EventArgs e)//借书 按键触发函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "exec usp_BorrowBook @rdID,@bkID";
                    comm.Parameters.AddWithValue("@rdID", tbRdID.Text);
                    comm.Parameters.AddWithValue("@bkID", tbBkID.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("借书成功！ ");
                    DataBind();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "借书失败！ ");
            }

        }

        private void button3_Click(object sender, EventArgs e)//查询点击函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "SELECT rdID  读者编号,bkID 书号,DateBorrow 借书日期,DateLendPlan 还书日期,rdtypename1 教师名字 FROM Borrow  where rdID like @rdID + '%'";
                    comm.Parameters.AddWithValue("@rdID", tbRdID.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgvRdCategory.DataSource = ds.Tables[0];//设置表格的数据源
                    DataBind(); //重新加载数据库中的数据（ 刷新窗体表格中的数据）
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuForm().Show();
        }

        private void dgvRdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
