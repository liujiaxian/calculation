using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wk.DataBase;
using System.Web;
using System.Web.UI.WebControls;

namespace wk
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();

            //foreach (int index in Enum.GetValues(typeof(UserType)))
            //{
            //    string name = Enum.GetName(typeof(UserType), index);//ex:餐馆   
            //    string value = index.ToString();//ex:9  
            //    //需要增加引用：System.Web  
            //    //引用命名空间：using System.Web.UI.WebControls;  
            //    //ListBox 也可用这个方法  
            //    ListItem item = new ListItem();
            //    item.Text = name;
            //    item.Value = value;
            //    comRole.Items.Add(item);
            //}
            //comRole.DataSource = System.Enum.GetNames(typeof(UserType));
            
            //comRole.SelectedIndex = 0;
        }



        private void btn_Pwd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("用户账号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("用户密码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string md5pwd = EncryptHelper.Md5(pwd);
            string sql = "select * from calculation_user where userName=@userName and userPwd=@userPwd"; ;

            SqlParameter[] pams ={
                                 new SqlParameter("@userName",username),
                                 new SqlParameter("@userPwd",md5pwd)
                                 };
            DataTable tb = SqlHelper.ExecuteDataTable(sql, pams);
            if (tb.Rows.Count > 0)
            {

                int id = 0;
                foreach (DataRow item in tb.Rows)
                {
                    id = Convert.ToInt32(item["userID"]);
                }
                UserInfo.loginName = username;
                UserInfo.password = pwd;
                UserInfo.userID = id;

                //更新时间
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string update = "update calculation_user set loginTime='" + time + "' where userID=" + id;
                int n = SqlHelper.ExecuteNonQuery(update);

                //MessageBox.Show("登录成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MyInfo f2 = new MyInfo();
                //f2.Show();
                Info i = new Info();
                i.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }


    }
}
