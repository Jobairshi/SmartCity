using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCity
{
    public partial class CreateUi : Form
    {
        public CreateUi()
        {
            InitializeComponent();
        }
        static bool Connect_Check(string user, string pass)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            SqlDataReader dreader;
            string sql;
            conn = new SqlConnection(constr);
            conn.Open();

            sql = "Select Name, Password from UserId";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                // output = output + dreader.GetValue(0) + " - " +
                //                   dreader.GetValue(1) + "\n";
                string us = dreader.GetString(0);
                string ps = dreader.GetString(1);
                if (us == user && ps == pass)
                {
                    return true;
                }
            }
            dreader.Close();
            cmd.Dispose();
            conn.Close();
            return false;

        }
        static void Add(string name,string pass,string mail)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();
            // data adapter object is use to
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();
            string s = "insert into UserId values('" + name + "','"+pass + "','"+mail+"')";
            // string sql = "insert into second values('shipuii','C202129')";
            string sql = s;
            SqlCommand cmd;
            // use to execute the sql command so we
            // are passing query and connection object
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            //  Console.WriteLine("Connection Open!");
            cmd.Dispose();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = user.Texts;
            string pass = password.Texts;
            string gmail = mail.Texts;
            Add(name, pass,gmail);
            Submit.BorderColor = Color.OrangeRed;
            Submit.Enabled = false;
        }
        
        private void Back_Click(object sender, EventArgs e)
        {

            UserUi obj = new UserUi();
            //   obj.Show(); 
            this.Visible = false;
        }
    }
}
