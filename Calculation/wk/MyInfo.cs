using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wk.DataBase;

namespace wk
{
    public partial class MyInfo : Form
    {
        public MyInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {



        }

        public void setname(string strname)
        {

        }

        //结算
        private void button1_Click_2(object sender, EventArgs e)
        {
            string stime = dateTimeStart.Text.Trim();
            string etime = dateTimeEnd.Text.Trim();
            if (stime.Length <= 0 || etime.Length <= 0)//搜索添加时间
            {
                MessageBox.Show("时间格式不正确！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            stime = Convert.ToDateTime(stime).ToString("yyyy-MM-dd");
            etime = Convert.ToDateTime(etime).ToString("yyyy-MM-dd");
            //开始按支出用户分组
            string sql = "select realName,userID,sum(money) as paysum from vyw_calculation_user_type where addTime>='" + stime + "' and addTime<='" + etime + "' group by realName,userID";
            DataTable tb = SqlHelper.ExecuteDataTable(sql);
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            double m1 = 0, m2 = 0, m3 = 0, m4 = 0;
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow item in tb.Rows)
                {
                    int userID = Convert.ToInt32(item["userID"]);
                    sb.Append("[" + item["realName"].ToString() + "]支出：   " + Convert.ToDecimal(item["paysum"]).ToString("0.00") + "\r\n\r\n");

                    string sql1 = "select typeName,typeID,sum(money) as payusersum from vyw_calculation_user_type where userID=" + userID + " and (addTime>='" + stime + "' and addTime<='" + etime + "') group by typeName,typeID";
                    DataTable tb1 = SqlHelper.ExecuteDataTable(sql1);
                    if (tb1.Rows.Count > 0)
                    {
                        foreach (DataRow item1 in tb1.Rows)
                        {
                            int typeid = Convert.ToInt32(item1["typeID"]);
                            double money = Convert.ToDouble(item1["payusersum"]);
                            double nowmoney = 0;
                            int count = 0;

                            if (typeid == 8)//全部
                            {
                                nowmoney = Math.Round(money * 1.0 / 4, 2);
                                count = 4;
                            }
                            else if (typeid == 1 || typeid == 10 || typeid == 11 || typeid == 12) //三人
                            {
                                nowmoney = Math.Round(money * 1.0 / 3, 2);
                                count = 3;
                            }
                            else //两人
                            {
                                nowmoney = Math.Round(money * 1.0 / 2, 2);
                                count = 2;
                            }

                            sb.Append("[" + item1["typeName"].ToString() + "]支出：   " + money.ToString("0.00") + "/" + count + "=" + nowmoney.ToString("0.00") + "\r\n");


                            if ((typeid == 1 || typeid == 2 || typeid == 3 || typeid == 4 || typeid == 8 || typeid == 10 || typeid == 11) && userID != 1)//嘉1
                            {
                                m1 += nowmoney;
                            }
                            if ((typeid == 1 || typeid == 2 || typeid == 6 || typeid == 7 || typeid == 8 || typeid == 11 || typeid == 12) && userID != 5)//超5
                            {
                                m2 += nowmoney;
                            }

                            if ((typeid == 1 || typeid == 3 || typeid == 5 || typeid == 6 || typeid == 8 || typeid == 10 || typeid == 12) && userID != 4)//辉4
                            {
                                m3 += nowmoney;
                            }
                            if ((typeid == 4 || typeid == 5 || typeid == 7 || typeid == 8 || typeid == 10 || typeid == 11 || typeid == 12)&&userID!=6)//斌6
                            {
                                m4 += nowmoney;
                            }

                        }
                    }
                    sb.Append("-------------------------------------------------\r\n\r\n");
                    
                }
            }
            sb1.Append("嘉支出：" + m1.ToString("0.00") + "\r\n");
            sb1.Append("超支出：" + m2.ToString("0.00") + "\r\n");
            sb1.Append("辉支出：" + m3.ToString("0.00") + "\r\n");
            sb1.Append("斌支出：" + m4.ToString("0.00") + "\r\n");
            txtPayUser.Text = sb.ToString() + sb1.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
            this.Hide();
        }

    }
}
