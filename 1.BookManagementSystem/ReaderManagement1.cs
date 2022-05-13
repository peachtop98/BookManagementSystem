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
    public partial class ReaderManagementForm : Form
    {
        string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = BookDB; User ID = sa; Password = 123456";
        public ReaderManagementForm()
        {
            InitializeComponent();
        }

        private void dgvRdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void empty()//将横框清空
        {
            tbRdType.Text = "";
            tbRdType.Text      = "";
            tbRdTypeName.Text  = "";
            tbCanLendQty.Text  = "";
            QQ1.Text           = "";
            textBox2.Text      = "";
            BorrowNum.Text = "";

        }
        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuForm().Show();
        }
        private void DataBind()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select rdID 编号,rdType 类别名,rdNme 姓名, rdDept 单位,rdQQ QQ," +
                        "rdBorrowQty 已借数量 from reader";
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
                    tbRdType.DataBindings.Add("Text", ds.Tables[0], "编号");//rdID，把得到的数据放入框框内
                    tbRdTypeName.DataBindings.Add("Text", ds.Tables[0], "类别名");//rdType把得到的数据放入框框内
                    textBox2.DataBindings.Add("Text", ds.Tables[0], "姓名");//rdNme把得到的数据放入框框内
                    tbCanLendQty.DataBindings.Add("Text", ds.Tables[0], "单位");//rdDept把得到的数据放入框框内
                    QQ1.DataBindings.Add("Text", ds.Tables[0], "QQ");//rdQQ把得到的数据放入框框内
                    BorrowNum.DataBindings.Add("Text", ds.Tables[0], "已借数量");//rdBorrowQty把得到的数据放入框框内
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)//添加按键事件
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "insert into reader values(@rdID,@rdType, @rdDept, @rdQQ,@rdNme,@rdBorrowQty)";
                    comm.Parameters.AddWithValue("@rdID", tbRdType.Text);
                    comm.Parameters.AddWithValue("@rdType", tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@rdDept", tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@rdQQ", QQ1.Text);
                    comm.Parameters.AddWithValue("@rdNme", textBox2.Text);
                    comm.Parameters.AddWithValue("@rdBorrowQty", BorrowNum.Text);
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
                empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //查询点击 事件
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select rdID 编号,rdType 类别名,rdNme 姓名,rdDept 单位,rdQQ QQ," +
                        "rdBorrowQty 已借数量 from reader where rdID like @rdID + '%'";
                    comm.Parameters.AddWithValue("@rdID", tbRdType.Text);
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

        private void ReaderManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//删除按键事件
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
                        comm.CommandText = "delete from reader where rdID =@rdID";
                        comm.Parameters.AddWithValue("@rdID", tbRdType.Text);
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

        private void button4_Click(object sender, EventArgs e)//修改按键事件
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "update reader set rdID = @rdID,rdType = @rdType,rdDept = @rdDept,rdQQ =@rdQQ," +
                        "rdNme = @rdNme,rdBorrowQty =@rdBorrowQty where rdID = @rdID";
                    comm.Parameters.AddWithValue("@rdID", tbRdType.Text);
                    comm.Parameters.AddWithValue("@rdType", tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@rdDept", tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@rdQQ", QQ1.Text);
                    comm.Parameters.AddWithValue("@rdNme", textBox2.Text);
                    comm.Parameters.AddWithValue("@rdBorrowQty", BorrowNum.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("修改成功！ ");
                    DataBind(); //重新加载数据库中的数据
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！ " + ex.Message);
            }
        }

        private void tbRdType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//清空框内数据
        {
            empty();
        }
    }
}
