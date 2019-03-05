using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using wk.DataBase;

namespace wk
{
    public partial class Info : Form
    {
        public static string id = "";
        private static int pageSize = 20;
        private static int pageIndex = 1;
        private static int count = 0;
        private static int pageCount = 0;
        private string sqlwhere = "1=1";
        public Info()
        {
            InitializeComponent();

            string sql = "select * from calculation_type";
            DataTable tb = SqlHelper.ExecuteDataTable(sql);
            comPayUser.DisplayMember = "typeName";
            comPayUser.ValueMember = "typeID";
            comPayUser.DataSource = tb;

            count = (int)SqlHelper.ExecuteScalar("select count(*) from vyw_calculation_user_type");
            pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);


            //DataBind();
            GetPageData();

            //为每行数据增加编辑列。
            //设定列不能自动作成
            dataGridView1.AutoGenerateColumns = false;
            //创建一个DataGridViewLinkColumn列
            DataGridViewLinkColumn dlink = new DataGridViewLinkColumn();
            dlink.Text = "编辑";//添加的这列的显示文字，即每行最后一列显示的文字。
            dlink.Name = "linkEdit";
            dlink.HeaderText = "编辑";//列的标题
            dlink.UseColumnTextForLinkValue = true;//上面设置的dlink.Text文字在列中显示
            dataGridView1.Columns.Add(dlink);//将创建的列添加到UserdataGridView中

            //同上方法为每条记录创建&ldquo;删除&rdquo;超链接
            DataGridViewLinkColumn dlink2 = new DataGridViewLinkColumn();
            dlink2.Text = "删除";
            dlink2.Name = "linkDelete";
            dlink2.HeaderText = "删除";
            dlink2.UseColumnTextForLinkValue = true;
            dataGridView1.Columns.Add(dlink2);



            this.dateAddTimeStart.Format = DateTimePickerFormat.Custom;
            this.dateAddTimeStart.CustomFormat = "   ";

            this.dateAddTimeEnd.Format = DateTimePickerFormat.Custom;
            this.dateAddTimeEnd.CustomFormat = "   ";
        }

        public void GetPageData()
        {


            string[] columns = { "infoID,remark,realName,typeName,money,addTime,updateTime" };
            string sql = SqlHelper.GenerateQuerySql("vyw_calculation_user_type", columns, pageIndex, pageSize, sqlwhere, "infoID", true);
            //string sql = "select top 14 a.userID,a.loginName,a.password,b.roleName,a.addTime,a.loginTime from t_user as a,t_role as b where a.roleID=b.roleID order by userID desc";
            DataTable tb = SqlHelper.ExecuteDataTable(sql);

            dataGridView1.DataSource = tb;
            dataGridView1.Columns["infoID"].HeaderText = "编号";
            dataGridView1.Columns["remark"].HeaderText = "支出";
            dataGridView1.Columns["realName"].HeaderText = "用户";
            dataGridView1.Columns["typeName"].HeaderText = "参与人员";
            dataGridView1.Columns["money"].HeaderText = "支出金额";
            dataGridView1.Columns["addTime"].HeaderText = "添加时间";
            dataGridView1.Columns["updateTime"].HeaderText = "更新时间";

            labAll.Text = pageCount.ToString();
            labCur.Text = pageIndex.ToString();
            txtPage.Text = pageIndex.ToString();


        }

        //数据绑定
        #region 无用
        //public void DataBind()
        //{
        //    string sql = "select top " + pageSize + " infoID,remark,userName,typeID,money,addTime,updateTime from vyw_calculation_user" + sqlwhere + " order by infoID desc";
        //    DataTable tb = SqlHelper.ExecuteDataTable(sql);

        //    List<CalculationInfo> list = new List<CalculationInfo>();
        //    if (tb.Rows.Count > 0)
        //    {
        //        foreach (DataRow item in tb.Rows)
        //        {
        //            CalculationInfo model = new CalculationInfo();
        //            model.infoID = Convert.ToInt32(item["infoID"]);
        //            model.remark = item["remark"].ToString();
        //            model.userName = item["userName"].ToString();
        //            model.typeName = Enum.GetName(typeof(PayUserType), Convert.ToInt32(item["typeID"]));
        //            model.money = Convert.ToDecimal(item["money"]).ToString("0.00");
        //            model.addTime = Convert.ToDateTime(item["addTime"]).ToString("yyyy-MM-dd HH:mm:ss");
        //            model.updateTime = string.IsNullOrEmpty(item["updateTime"].ToString()) == true ? "" : Convert.ToDateTime(item["updateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
        //            list.Add(model);
        //        }
        //    }

        //    dataGridView1.DataSource = list;
        //    dataGridView1.Columns["infoID"].HeaderText = "编号";
        //    dataGridView1.Columns["remark"].HeaderText = "支出";
        //    dataGridView1.Columns["userName"].HeaderText = "用户";
        //    dataGridView1.Columns["typeName"].HeaderText = "参与人员";
        //    dataGridView1.Columns["money"].HeaderText = "支出金额";
        //    dataGridView1.Columns["addTime"].HeaderText = "添加时间";
        //    dataGridView1.Columns["updateTime"].HeaderText = "更新时间";
        //    if (UserInfo.roleID != (int)UserType.管理员)
        //    {
        //        dataGridView1.Columns["loginName"].Visible = false;
        //    }

        //} 
        #endregion

        //添加信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InfoAdd add = new InfoAdd();
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                GetPageData();//重新绑定
            }
        }
        //跳转
        private void button1_Click(object sender, EventArgs e)
        {
            int page;
            if (!int.TryParse(txtPage.Text, out page))
            {
                txtPage.Text = pageIndex.ToString();
                MessageBox.Show("页码只能输入整数！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (page > pageCount)
            {
                txtPage.Text = pageIndex.ToString();
                MessageBox.Show("页码不能大于总页数！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (page < 1)
            {
                txtPage.Text = pageIndex.ToString();
                MessageBox.Show("页码不能小于1！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pageIndex = page;
            GetPageData();
        }
        //首页
        private void linkFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;

            GetPageData();
        }
        //尾页
        private void linkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;

            GetPageData();
        }
        //上一页
        private void linkPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = pageIndex - 1;
            }
            else
            {
                linkNext.Enabled = true;
            }

            GetPageData();
        }
        //下一页
        private void linkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageIndex + 1;
            }
            else
            {
                linkNext.Enabled = true;
            }
            GetPageData();
        }
        //操作
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "linkEdit")
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();  //这里引用了 e 这个变量
                InfoEdit edit = new InfoEdit();
                edit.ShowDialog();
                if (edit.DialogResult == DialogResult.OK)
                {
                    GetPageData();//重新绑定
                }
                // MessageBox.Show("触发了编辑按钮");
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "linkDelete")
            {
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int aaa = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value.ToString());  //这里引用了 e 这个变量
                    string sql = "delete from calculation_info where infoID=" + aaa;
                    int n = SqlHelper.ExecuteNonQuery(sql);
                    if (n > 0)
                    {
                        GetPageData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        //搜索
        private void button2_Click(object sender, EventArgs e)
        {
            //groPage.Visible = false;

            string user = txtPayUser.Text.Trim();
            int payuser = Convert.ToInt32(comPayUser.SelectedValue);
            string money = txtMoney.Text.Trim();
            //添加时间
            string stime = dateAddTimeStart.Text.Trim();
            string etime = dateAddTimeEnd.Text.Trim();

            StringBuilder sql = new StringBuilder();


            List<string> wheres = new List<string>();


            if (user.Length > 0)//搜索额度
            {
                wheres.Add(" userName like '%" + user + "%'");
            }
            if (payuser != 0)//搜索额度
            {
                wheres.Add(" typeID=" + payuser);
            }
            if (money.Length > 0)//搜索额度
            {
                wheres.Add(" money like '%" + money + "%'");
            }
            if (stime.Length > 0 && etime.Length > 0)//搜索添加时间
            {
                stime = Convert.ToDateTime(stime).ToString("yyyy-MM-dd");
                etime = Convert.ToDateTime(etime).ToString("yyyy-MM-dd");
                wheres.Add(" CONVERT(varchar(10), addTime, 120)>='" + stime + "' and CONVERT(varchar(10), addTime, 120)<='" + etime + "'");
            }

            //判断用户是否选择了条件
            if (wheres.Count > 0)
            {
                string wh = string.Join(" and ", wheres.ToArray());
                sql.Append(" " + wh);
            }

            pageIndex = 1;

            count = (int)SqlHelper.ExecuteScalar("select count(*) from vyw_calculation_user_type where " + sql.ToString());
            pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            sqlwhere = sql.ToString();
            GetPageData();
        }

        private void dateAddTime_ValueChanged(object sender, EventArgs e)
        {
            //this.dateTimePicker1.Format=DateTimePickerFormat.Long;
            this.dateAddTimeStart.CustomFormat = null;
            this.dateAddTimeEnd.CustomFormat = null;
        }
        //重置搜索条件
        private void button3_Click(object sender, EventArgs e)
        {
            string user = txtPayUser.Text.Trim();
            int payuser = Convert.ToInt32(comPayUser.SelectedValue);
            string money = txtMoney.Text.Trim();
            //添加时间
            string stime = dateAddTimeStart.Text.Trim();
            string etime = dateAddTimeEnd.Text.Trim();
            txtMoney.Text = "";
            txtPayUser.Text = "";
            sqlwhere = "1=1";
            count = (int)SqlHelper.ExecuteScalar("select count(*) from vyw_calculation_user_type");
            pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);
            GetPageData();
        }

        //结算
        private void button4_Click(object sender, EventArgs e)
        {
            MyInfo f2 = new MyInfo();
            f2.ShowDialog();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }
}
