using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.BookManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private static MainMenuForm menuForm = null;
        public static MainMenuForm getInstance()
        { //单例模式
            if (menuForm == null)
            {
                menuForm = new MainMenuForm(); //创建当前窗体实例对象
            }
            return menuForm;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            menuForm = null; //窗体的实例对象设置为 null
            Application.Exit();//退出当前系统
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new ReaderCategoryForm().Show(); //显示读者类别窗体
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new BookManagementForm().Show(); //显示图书管理窗体
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new ReaderManagementForm().Show(); //显示读者管理窗体
        }

        private void btnBorrRet_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new Borrowbooks().Show(); //显示借书还书窗体
        }
    }
}
