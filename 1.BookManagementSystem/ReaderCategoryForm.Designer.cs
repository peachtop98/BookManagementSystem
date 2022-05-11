namespace _1.BookManagementSystem
{
    partial class ReaderCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderCategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRdType = new System.Windows.Forms.TextBox();
            this.tbCanLendDay = new System.Windows.Forms.TextBox();
            this.tbCanLendQty = new System.Windows.Forms.TextBox();
            this.tbRdTypeName = new System.Windows.Forms.TextBox();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.dgvRdCategory = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(67, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "可借书天数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(67, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "可借书数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "类别名称";
            // 
            // tbRdType
            // 
            this.tbRdType.Location = new System.Drawing.Point(70, 68);
            this.tbRdType.Name = "tbRdType";
            this.tbRdType.Size = new System.Drawing.Size(118, 25);
            this.tbRdType.TabIndex = 4;
            this.tbRdType.TextChanged += new System.EventHandler(this.tbRdType_TextChanged);
            // 
            // tbCanLendDay
            // 
            this.tbCanLendDay.Location = new System.Drawing.Point(70, 263);
            this.tbCanLendDay.Name = "tbCanLendDay";
            this.tbCanLendDay.Size = new System.Drawing.Size(118, 25);
            this.tbCanLendDay.TabIndex = 5;
            // 
            // tbCanLendQty
            // 
            this.tbCanLendQty.Location = new System.Drawing.Point(70, 203);
            this.tbCanLendQty.Name = "tbCanLendQty";
            this.tbCanLendQty.Size = new System.Drawing.Size(118, 25);
            this.tbCanLendQty.TabIndex = 6;
            // 
            // tbRdTypeName
            // 
            this.tbRdTypeName.Location = new System.Drawing.Point(70, 136);
            this.tbRdTypeName.Name = "tbRdTypeName";
            this.tbRdTypeName.Size = new System.Drawing.Size(118, 25);
            this.tbRdTypeName.TabIndex = 7;
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
            this.btnBackMenu.Location = new System.Drawing.Point(70, 314);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(118, 57);
            this.btnBackMenu.TabIndex = 8;
            this.btnBackMenu.Text = "返回主菜单";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // dgvRdCategory
            // 
            this.dgvRdCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvRdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRdCategory.Location = new System.Drawing.Point(227, 68);
            this.dgvRdCategory.Name = "dgvRdCategory";
            this.dgvRdCategory.RowHeadersWidth = 51;
            this.dgvRdCategory.RowTemplate.Height = 27;
            this.dgvRdCategory.Size = new System.Drawing.Size(596, 313);
            this.dgvRdCategory.TabIndex = 14;
            this.dgvRdCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(242, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(70, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(404, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(562, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReaderCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 494);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRdCategory);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.tbRdTypeName);
            this.Controls.Add(this.tbCanLendQty);
            this.Controls.Add(this.tbCanLendDay);
            this.Controls.Add(this.tbRdType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ReaderCategoryForm";
            this.Text = "读者类别";
            this.Load += new System.EventHandler(this.ReaderCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRdType;
        private System.Windows.Forms.TextBox tbCanLendDay;
        private System.Windows.Forms.TextBox tbCanLendQty;
        private System.Windows.Forms.TextBox tbRdTypeName;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.DataGridView dgvRdCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}