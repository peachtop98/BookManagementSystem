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
    public partial class ReaderCategoryForm : Form
    {
        string connStr = "Data source=阿斯顿\\SQLEXPRESS;Initial Catalog = BookDB; User ID = sa; Password = 123456";
        public ReaderCategoryForm()
        {
            InitializeComponent();
        }
        private void empty()//将横框清空
        {
            tbRdType.Text = "";
            tbCanLendDay.Text = "";
            tbRdTypeName.Text = "";
            tbCanLendQty.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvRdCategory.DefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dgvRdCategory.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvRdCategory.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvRdCategory.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvRdCategory.DefaultCellStyle.SelectionBackColor = Color.Black;
            DataBind();
        }
        private void DataBind()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select rdType 类别号,rdTypeName 类别名称,canLendQty 可借数量, canLendDay 可借天数 from ReaderType";//生成一行 列名，|类别号|类别名称|可借数量|可借天数
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgvRdCategory.DataSource = ds.Tables[0];
                    tbRdType.DataBindings.Clear();
                    tbRdTypeName.DataBindings.Clear();
                    tbCanLendQty.DataBindings.Clear();
                    tbCanLendDay.DataBindings.Clear();
                    tbRdType.DataBindings.Add("Text", ds.Tables[0], "类别号");
                    tbRdTypeName.DataBindings.Add("Text", ds.Tables[0], "类别名称");
                    tbCanLendQty.DataBindings.Add("Text", ds.Tables[0], "可借数量");
                    tbCanLendDay.DataBindings.Add("Text", ds.Tables[0], "可借天数");
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

        private void ReaderCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void tbRdType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//添加——按键
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "insert into ReaderType values(@rdType,@rdTypeName, @canLendQty, @canLendDay)";
                    comm.Parameters.AddWithValue("@rdType", tbRdType.Text);
                    comm.Parameters.AddWithValue("@rdTypeName", tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@canLendQty", tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@canLendDay", tbCanLendDay.Text);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！ " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//查询_查询
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select rdType 类别号,rdTypeName 类别名称,canLendQty 可借数量, canLendDay 可借天数 from ReaderType where rdType like @rdType + '%'";
                    comm.Parameters.AddWithValue("@rdType", tbRdType.Text);
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

        private void button3_Click(object sender, EventArgs e)//删除_按键
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
                        comm.CommandText = "delete from ReaderType where rdType =@rdType";
                        comm.Parameters.AddWithValue("@rdType", tbRdType.Text);
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
        }

        private void button4_Click(object sender, EventArgs e)//修改_按键
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "update ReaderType set rdType = @rdType,rdTypeName = @rdTypeName,canLendQty = @canLendQty,canLendDay =@canLendDay where rdType = @rdType";
                    comm.Parameters.AddWithValue("@rdType", tbRdType.Text);
                    comm.Parameters.AddWithValue("@rdTypeName",tbRdTypeName.Text);
                    comm.Parameters.AddWithValue("@canLendQty",tbCanLendQty.Text);
                    comm.Parameters.AddWithValue("@canLendDay",tbCanLendDay.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("修改成功！ ");
                    DataBind(); //重新加载数据库中的数据
                }
            } catch(Exception ex)
            {
                MessageBox.Show("修改失败！ " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            empty();
        }
    }
 }

