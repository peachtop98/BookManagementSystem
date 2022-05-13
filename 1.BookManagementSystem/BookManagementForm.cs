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
    public partial class BookManagementForm : Form
    {
        string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = BookDB; User ID = sa; Password = 123456";
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void empty()//将横框清空
        {
            tbRdType.Text = "";
            tbRdType.Text = "";
            tbRdTypeName.Text = "";
            tbCanLendQty.Text = "";
            QQ1.Text = "";
            textBox2.Text = "";
            BorrowNum.Text = "";

        }
        private void DataBind()//刷新窗口，将数据填入空中
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select bkID 书号,bkName 书名,bkAuthor 作者, bkPress 出版社,bkprice 单价," +
                        "bkStatus 状态 from BookTable";
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgvRdCategory.DataSource = ds.Tables[0];
                    tbRdType.DataBindings.Clear();
                    tbRdTypeName.DataBindings.Clear();
                    tbCanLendQty.DataBindings.Clear();
                    QQ1.DataBindings.Clear();
                    textBox2.DataBindings.Clear();
                    BorrowNum.DataBindings.Clear();
                    tbRdType.DataBindings.Add("Text", ds.Tables[0], "书号");//rdID
                    tbRdTypeName.DataBindings.Add("Text", ds.Tables[0], "书名");//rdType
                    textBox2.DataBindings.Add("Text", ds.Tables[0], "作者");//rdDept
                    tbCanLendQty.DataBindings.Add("Text", ds.Tables[0], "出版社");//rdQQ
                    QQ1.DataBindings.Add("Text", ds.Tables[0], "单价");//rdNme
                    BorrowNum.DataBindings.Add("Text", ds.Tables[0], "状态");//rdBorrowQty
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

        private void button2_Click(object sender, EventArgs e)//添加按键的触发函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "insert into BookTable values(@bkID,@bkName,@bkAuthor,@bkPress,@bkprice,@bkStatus)";
                    comm.Parameters.AddWithValue("@bkID", tbRdType.Text);
                    comm.Parameters.AddWithValue("@bkName", tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@bkAuthor", textBox2.Text);
                    comm.Parameters.AddWithValue("@bkPress", tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@bkprice", QQ1.Text);
                    comm.Parameters.AddWithValue("@bkStatus", BorrowNum.Text);
                    try
                    {
                        comm.ExecuteNonQuery();//执行 SQL 语句
                        MessageBox.Show("添加成功！ ");
                        DataBind(); //重新加载数据库中的数据（ 刷新窗体表格中的数据）
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("添加失败！ " + ex.Message);
                    }
                }
                //empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//查询触发函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select bkID 书号,bkName 书名,bkAuthor 作者, bkPress 出版社,bkprice 单价," +
                        "bkStatus 状态 from BookTable where bkID like @bkID + '%'";
                    comm.Parameters.AddWithValue("@bkID", tbRdType.Text);
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
            //empty();
        }

        private void button3_Click(object sender, EventArgs e)//删除触发函数
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "确定", messButton);
            if (dr == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open(); //打开数据库连接
                        SqlCommand comm = conn.CreateCommand();
                        comm.CommandText = "delete from BookTable where bkID =@bkID";
                        comm.Parameters.AddWithValue("@bkID", tbRdType.Text);
                        comm.ExecuteNonQuery(); //执行 SQL 语句
                        MessageBox.Show("删除成功！ ");
                        DataBind(); //重新加载数据
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败！ " + ex.Message);
                }

            }
            //empty();
        }

        private void dgvRdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//修改按键触发函数
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "update BookTable set bkID = @bkID,bkName = @bkName,bkAuthor = @bkAuthor,bkPress =@bkPress," +
                        "bkprice = @bkprice,bkStatus =@bkStatus where bkID = @bkID";
                    comm.Parameters.AddWithValue("@bkID", tbRdType.Text);
                    comm.Parameters.AddWithValue("@bkName", tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@bkAuthor", textBox2.Text);
                    comm.Parameters.AddWithValue("@bkPress", tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@bkprice", QQ1.Text);
                    comm.Parameters.AddWithValue("@bkStatus", BorrowNum.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("修改成功！ ");
                    DataBind(); //重新加载数据库中的数据
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！ " + ex.Message);
            }
            //empty();//修改不能清空
        }

        private void button5_Click(object sender, EventArgs e)
        {
            empty();
        }
    }
}
