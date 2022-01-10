using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCity
{
    public partial class AdminPanelUi : Form
    {
        public AdminPanelUi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            activeForm.Close();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;   
            more.Enabled = true;
            openChildForm(new DeleteUserUi());
        }

        private void more_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled=true;  
            more.Enabled=false;
            MessageBox.Show("Wait For Update Version To Come 🎶🎶");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminLoginUi obj = new AdminLoginUi();
            this.Visible = false;
            //obj.Show(); 
        }
    }
}
