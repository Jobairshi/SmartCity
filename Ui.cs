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
    public partial class Ui : Form
    {
        public Ui()
        {
            InitializeComponent();
        }

        private void Ui_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new UserUi());
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminLoginUi());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AgentLoginUi());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutUi());
        }
    }
}
