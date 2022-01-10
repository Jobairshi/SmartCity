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
    public partial class AgentPanelUi : Form
    {
        public AgentPanelUi()
        {
            InitializeComponent();
        }

        private void AgentPanelUi_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AgentLoginUi obj = new AgentLoginUi();
            this.Visible = false;
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
        private void Addhouse_Click(object sender, EventArgs e)
        {
            openChildForm(new AddHouseUi());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
        }

        private void AddHotels_Click(object sender, EventArgs e)
        {
           openChildForm(new AddHotelsUi());
        }
    }
}
