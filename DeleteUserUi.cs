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
    public partial class DeleteUserUi : Form
    {
        public DeleteUserUi()
        {
            InitializeComponent();
        }
        static bool Connect_Check(string mail)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            SqlDataReader dreader;
            string sql;
            conn = new SqlConnection(constr);
            conn.Open();

            sql = "Select Name, Password,mail from UserId";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            int i = 0;
            while (dreader.Read())
            {
                // output = output + dreader.GetValue(0) + " - " +
                //                   dreader.GetValue(1) + "\n";
               
                string us = dreader.GetString(0);
                string ps = dreader.GetString(1);
                string ml = dreader.GetString(2);
                if (ml == mail)
                {
                    return true;
                }
                i++;
            }
            dreader.Close();
            cmd.Dispose();
            conn.Close();
            return false;
        }
        static void Delete(string mail)
        {
            string constr;
            SqlConnection conn;
            SqlDataAdapter adap = new SqlDataAdapter();
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            string sql = "";
            conn = new SqlConnection(constr);
            conn.Open();
            sql = "delete from userId where mail='"+mail+"';";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dreader;
            dreader = cmd.ExecuteReader();
            MessageBox.Show("Deleted");
            dreader.Close();
            cmd.Dispose();
            conn.Close();
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminLoginUi());
            this.Visible = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string mail = userName.Texts;
            if(Connect_Check(mail))
            {
                Delete(mail);
            }
            else
            {
                MessageBox.Show("Mail Not Found");
            }
        }
    }
}
