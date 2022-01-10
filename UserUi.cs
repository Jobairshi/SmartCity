using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace SmartCity
{
    public partial class UserUi : Form
    {
        
        public UserUi()
        {
            InitializeComponent();
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void UserUi_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customTextBox2__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            container.Controls.Add(childForm);
            container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CreateUi());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string name = user.Texts;
            string pass = password.Texts;
           
            Console.WriteLine(name + " " + pass);   
            Console.ReadLine();
            if (Connect_Check(name, pass) == true)
            {
               // this.Hide();
                openChildForm(new UserFacilityUi());
                warn.Text = "";
                user.Texts = "";
                password.Texts = "";
            }
            else
            {
                //MessageBox.Show("Failed!!");
                warn.Text = "Wrong UserName or PassWord , Try Again";
            }
            // openChildForm(new UserFacilityUi());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Ui obj = new Ui();  
            this.Visible = false;
        }
      
    }
}
