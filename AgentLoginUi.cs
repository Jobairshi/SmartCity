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
    public partial class AgentLoginUi : Form
    {
        public AgentLoginUi()
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

            sql = "Select name, password from Agent";
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
        private void Back_Click(object sender, EventArgs e)
        {
            Ui obj = new Ui();  
            this.Visible = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = user.Texts;
            string pass = password.Texts;

            Console.WriteLine(name + " " + pass);
            Console.ReadLine();
            if (Connect_Check(name, pass) == true)
            {
                // this.Hide();
                // warn.Text = "";
                openChildForm(new AgentPanelUi());
                // MessageBox.Show("Good To go❤❤!!");
                user.Texts = "";
                password.Texts = "";
            }
            else
            {
                MessageBox.Show("Wrong UserName or PassWord, Try Again😢😢!!");
                //warn.Text = "Wrong UserName or PassWord , Try Again";
            }
            // openChildForm(new UserFacilityUi());
        }
    }
}
