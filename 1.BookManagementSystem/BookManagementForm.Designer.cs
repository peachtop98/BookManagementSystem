namespace _1.BookManagementSystem
{
    partial class BookManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BorrowNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRdCategory = new System.Windows.Forms.DataGridView();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.tbRdTypeName = new System.Windows.Forms.TextBox();
            this.tbCanLendQty = new System.Windows.Forms.TextBox();
            this.QQ1 = new System.Windows.Forms.TextBox();
            this.tbRdType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 25);
            this.textBox2.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "作者";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BorrowNum
            // 
            this.BorrowNum.Location = new System.Drawing.Point(39, 281);
            this.BorrowNum.Name = "BorrowNum";
            this.BorrowNum.Size = new System.Drawing.Size(118, 25);
            this.BorrowNum.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "状态（1:在馆，0:不在管）";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(650, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 47);
            this.button4.TabIndex = 50;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(445, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 47);
            this.button3.TabIndex = 49;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(41, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 47);
            this.button2.TabIndex = 48;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(243, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 47;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvRdCategory
            // 
            this.dgvRdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRdCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvRdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRdCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvRdCategory.Location = new System.Drawing.Point(220, 22);
            this.dgvRdCategory.Name = "dgvRdCategory";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRdCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRdCategory.RowHeadersWidth = 51;
            this.dgvRdCategory.RowTemplate.Height = 27;
            this.dgvRdCategory.Size = new System.Drawing.Size(636, 366);
            this.dgvRdCategory.TabIndex = 46;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBackMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.BackgroundImage")));
            this.btnBackMenu.FlatAppearance.BorderSize = 0;
            this.btnBackMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBackMenu.Location = new System.Drawing.Point(41, 337);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(118, 63);
            this.btnBackMenu.TabIndex = 45;
            this.btnBackMenu.Text = "返回主菜单";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            // 
            // tbRdTypeName
            // 
            this.tbRdTypeName.Location = new System.Drawing.Point(39, 93);
            this.tbRdTypeName.Name = "tbRdTypeName";
            this.tbRdTypeName.Size = new System.Drawing.Size(118, 25);
            this.tbRdTypeName.TabIndex = 44;
            // 
            // tbCanLendQty
            // 
            this.tbCanLendQty.Location = new System.Drawing.Point(39, 190);
            this.tbCanLendQty.Name = "tbCanLendQty";
            this.tbCanLendQty.Size = new System.Drawing.Size(118, 25);
            this.tbCanLendQty.TabIndex = 43;
            // 
            // QQ1
            // 
            this.QQ1.Location = new System.Drawing.Point(39, 234);
            this.QQ1.Name = "QQ1";
            this.QQ1.Size = new System.Drawing.Size(118, 25);
            this.QQ1.TabIndex = 42;
            // 
            // tbRdType
            // 
            this.tbRdType.Location = new System.Drawing.Point(39, 40);
            this.tbRdType.Name = "tbRdType";
            this.tbRdType.Size = new System.Drawing.Size(118, 25);
            this.tbRdType.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "出版社";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "单价";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "书号";
            // 
            // BookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(887, 531);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BorrowNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRdCategory);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.tbRdTypeName);
            this.Controls.Add(this.tbCanLendQty);
            this.Controls.Add(this.QQ1);
            this.Controls.Add(this.tbRdType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "BookManagementForm";
            this.Text = "图书管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BorrowNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRdCategory;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.TextBox tbRdTypeName;
        private System.Windows.Forms.TextBox tbCanLendQty;
        private System.Windows.Forms.TextBox QQ1;
        private System.Windows.Forms.TextBox tbRdType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}