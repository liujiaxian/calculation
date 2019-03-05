namespace wk
{
    partial class Info
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
            this.components = new System.ComponentModel.Container();
            this.groInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winAppDataSet1 = new wk.winAppDataSet1();
            this.t_infoTableAdapter = new wk.winAppDataSet1TableAdapters.t_infoTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labCur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.linkNext = new System.Windows.Forms.LinkLabel();
            this.linkLast = new System.Windows.Forms.LinkLabel();
            this.linkFirst = new System.Windows.Forms.LinkLabel();
            this.linkPrev = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAddTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPayUser = new System.Windows.Forms.ComboBox();
            this.dateAddTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groPage = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winAppDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groInfo
            // 
            this.groInfo.Controls.Add(this.dataGridView1);
            this.groInfo.Location = new System.Drawing.Point(12, 91);
            this.groInfo.Name = "groInfo";
            this.groInfo.Size = new System.Drawing.Size(907, 518);
            this.groInfo.TabIndex = 0;
            this.groInfo.TabStop = false;
            this.groInfo.Text = "所有录入信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(901, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tinfoBindingSource
            // 
            this.tinfoBindingSource.DataMember = "t_info";
            this.tinfoBindingSource.DataSource = this.winAppDataSet1;
            // 
            // winAppDataSet1
            // 
            this.winAppDataSet1.DataSetName = "winAppDataSet1";
            this.winAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_infoTableAdapter
            // 
            this.t_infoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 626);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加信息";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labAll
            // 
            this.labAll.AutoSize = true;
            this.labAll.Location = new System.Drawing.Point(220, 21);
            this.labAll.Name = "labAll";
            this.labAll.Size = new System.Drawing.Size(11, 12);
            this.labAll.TabIndex = 17;
            this.labAll.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "/";
            // 
            // labCur
            // 
            this.labCur.AutoSize = true;
            this.labCur.Location = new System.Drawing.Point(195, 21);
            this.labCur.Name = "labCur";
            this.labCur.Size = new System.Drawing.Size(11, 12);
            this.labCur.TabIndex = 15;
            this.labCur.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "跳转";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(246, 17);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(47, 21);
            this.txtPage.TabIndex = 9;
            // 
            // linkNext
            // 
            this.linkNext.AutoSize = true;
            this.linkNext.Location = new System.Drawing.Point(100, 21);
            this.linkNext.Name = "linkNext";
            this.linkNext.Size = new System.Drawing.Size(41, 12);
            this.linkNext.TabIndex = 9;
            this.linkNext.TabStop = true;
            this.linkNext.Text = "下一页";
            this.linkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNext_LinkClicked);
            // 
            // linkLast
            // 
            this.linkLast.AutoSize = true;
            this.linkLast.Location = new System.Drawing.Point(145, 21);
            this.linkLast.Name = "linkLast";
            this.linkLast.Size = new System.Drawing.Size(29, 12);
            this.linkLast.TabIndex = 10;
            this.linkLast.TabStop = true;
            this.linkLast.Text = "尾页";
            this.linkLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLast_LinkClicked);
            // 
            // linkFirst
            // 
            this.linkFirst.AutoSize = true;
            this.linkFirst.Location = new System.Drawing.Point(18, 21);
            this.linkFirst.Name = "linkFirst";
            this.linkFirst.Size = new System.Drawing.Size(29, 12);
            this.linkFirst.TabIndex = 11;
            this.linkFirst.TabStop = true;
            this.linkFirst.Text = "首页";
            this.linkFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFirst_LinkClicked);
            // 
            // linkPrev
            // 
            this.linkPrev.AutoSize = true;
            this.linkPrev.Location = new System.Drawing.Point(53, 21);
            this.linkPrev.Name = "linkPrev";
            this.linkPrev.Size = new System.Drawing.Size(41, 12);
            this.linkPrev.TabIndex = 12;
            this.linkPrev.TabStop = true;
            this.linkPrev.Text = "上一页";
            this.linkPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrev_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "支出用户:";
            // 
            // txtPayUser
            // 
            this.txtPayUser.Location = new System.Drawing.Point(77, 15);
            this.txtPayUser.Name = "txtPayUser";
            this.txtPayUser.Size = new System.Drawing.Size(201, 21);
            this.txtPayUser.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "参与用户:";
            // 
            // dateAddTimeStart
            // 
            this.dateAddTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateAddTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAddTimeStart.Location = new System.Drawing.Point(77, 43);
            this.dateAddTimeStart.Name = "dateAddTimeStart";
            this.dateAddTimeStart.Size = new System.Drawing.Size(200, 21);
            this.dateAddTimeStart.TabIndex = 3;
            this.dateAddTimeStart.ValueChanged += new System.EventHandler(this.dateAddTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "添加时间:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comPayUser);
            this.groupBox1.Controls.Add(this.dateAddTimeEnd);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateAddTimeStart);
            this.groupBox1.Controls.Add(this.txtPayUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 73);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // comPayUser
            // 
            this.comPayUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPayUser.FormattingEnabled = true;
            this.comPayUser.Location = new System.Drawing.Point(365, 17);
            this.comPayUser.Name = "comPayUser";
            this.comPayUser.Size = new System.Drawing.Size(202, 20);
            this.comPayUser.TabIndex = 1;
            // 
            // dateAddTimeEnd
            // 
            this.dateAddTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateAddTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAddTimeEnd.Location = new System.Drawing.Point(301, 43);
            this.dateAddTimeEnd.Name = "dateAddTimeEnd";
            this.dateAddTimeEnd.Size = new System.Drawing.Size(206, 21);
            this.dateAddTimeEnd.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(775, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "重置搜索条件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(664, 15);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(184, 21);
            this.txtMoney.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "支出金额:";
            // 
            // groPage
            // 
            this.groPage.Controls.Add(this.linkNext);
            this.groPage.Controls.Add(this.txtPage);
            this.groPage.Controls.Add(this.labAll);
            this.groPage.Controls.Add(this.linkLast);
            this.groPage.Controls.Add(this.button1);
            this.groPage.Controls.Add(this.label1);
            this.groPage.Controls.Add(this.linkFirst);
            this.groPage.Controls.Add(this.linkPrev);
            this.groPage.Controls.Add(this.labCur);
            this.groPage.Location = new System.Drawing.Point(538, 626);
            this.groPage.Name = "groPage";
            this.groPage.Size = new System.Drawing.Size(376, 46);
            this.groPage.TabIndex = 33;
            this.groPage.TabStop = false;
            this.groPage.Text = "分页";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 626);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "结算功能";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 688);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groInfo);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录入信息管理系统";
            this.Load += new System.EventHandler(this.Info_Load);
            this.groInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winAppDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groPage.ResumeLayout(false);
            this.groPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private winAppDataSet1 winAppDataSet1;
        private System.Windows.Forms.BindingSource tinfoBindingSource;
        private winAppDataSet1TableAdapters.t_infoTableAdapter t_infoTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.LinkLabel linkNext;
        private System.Windows.Forms.LinkLabel linkLast;
        private System.Windows.Forms.LinkLabel linkFirst;
        private System.Windows.Forms.LinkLabel linkPrev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAddTimeStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groPage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateAddTimeEnd;
        private System.Windows.Forms.ComboBox comPayUser;
        private System.Windows.Forms.Button button4;
    }
}