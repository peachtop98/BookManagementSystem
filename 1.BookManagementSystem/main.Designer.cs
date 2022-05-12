namespace _1.BookManagementSystem
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnBorrRet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Location = new System.Drawing.Point(212, 168);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(86, 36);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "读者类别";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Location = new System.Drawing.Point(518, 152);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(114, 40);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "图书管理";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.Color.Transparent;
            this.btnReader.FlatAppearance.BorderSize = 0;
            this.btnReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReader.Location = new System.Drawing.Point(343, 326);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(96, 31);
            this.btnReader.TabIndex = 2;
            this.btnReader.Text = "读者管理";
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnBorrRet
            // 
            this.btnBorrRet.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrRet.FlatAppearance.BorderSize = 0;
            this.btnBorrRet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrRet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrRet.Location = new System.Drawing.Point(627, 320);
            this.btnBorrRet.Name = "btnBorrRet";
            this.btnBorrRet.Size = new System.Drawing.Size(96, 37);
            this.btnBorrRet.TabIndex = 3;
            this.btnBorrRet.Text = "借书还书";
            this.btnBorrRet.UseVisualStyleBackColor = false;
            this.btnBorrRet.Click += new System.EventHandler(this.btnBorrRet_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(651, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(892, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBorrRet);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCategory);
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Button btnBorrRet;
        private System.Windows.Forms.Button btnExit;
    }
}