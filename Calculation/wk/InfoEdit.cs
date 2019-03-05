using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using wk.DataBase;

namespace wk
{
    public partial class InfoEdit : Form
    {
        public int id = Convert.ToInt32(Info.id);
        public InfoEdit()
        {
            InitializeComponent();

            string sql2 = "select * from calculation_type";
            DataTable tb2 = SqlHelper.ExecuteDataTable(sql2);
            comPayUserType.DisplayMember = "typeName";
            comPayUserType.ValueMember = "typeID";
            comPayUserType.DataSource = tb2;

            string sql1 = "select * from calculation_user";
            DataTable tb1 = SqlHelper.ExecuteDataTable(sql1);
            comPayUser.DisplayMember = "realName";
            comPayUser.ValueMember = "userID";
            comPayUser.DataSource = tb1;

            string sql = "select * from calculation_info where infoID=" + id;
            DataTable tb = SqlHelper.ExecuteDataTable(sql);
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow item in tb.Rows)
                {
                    comPayUser.SelectedValue = item["userID"].ToString();
                    comPayUserType.SelectedValue = item["typeID"].ToString();
                    dateTimeAdd.Text = item["addTime"].ToString();

                    txtMoney.Text = Convert.ToDecimal(item["money"]).ToString("0.00");
                    txtReamrk.Text = item["remark"].ToString();
                }
            }

        }
        //编辑
        private void button1_Click(object sender, EventArgs e)
        {
            int name = Convert.ToInt32(comPayUser.SelectedValue);

            int type = Convert.ToInt32(comPayUserType.SelectedValue);

            string money = txtMoney.Text.Trim();
            if (string.IsNullOrEmpty(money))
            {
                MessageBox.Show("支出金额不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(money, @"^(([0-9]|([1-9][0-9]{0,9}))((\.[0-9]{1,2})?))$"))
            {
                MessageBox.Show("支出金额格式不正确！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(money) <= 0)
            {
                MessageBox.Show("支出金额不能小于0！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime time = Convert.ToDateTime(dateTimeAdd.Text);

            string remark = txtReamrk.Text.Trim();
            if (string.IsNullOrEmpty(remark))
            {
                MessageBox.Show("备注不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "update calculation_info set userID=@userID,remark=@remark,typeID=@typeID,money=@money,addTime=@addTime,updateTime=@updateTime where infoID=@infoID";
            SqlParameter[] pams = { 
                                  new SqlParameter("@userID",name),
                                  new SqlParameter("@remark",remark),
                                  new SqlParameter("@typeID",type),
                                  new SqlParameter("@money",money),
                                  new SqlParameter("@addTime",time),
                                  new SqlParameter("@updateTime",DateTime.Now),
                                  new SqlParameter("@infoID",id)
                                  };
            int n = SqlHelper.ExecuteNonQuery(sql, pams);
            if (n > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("更新失败，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //返回
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
