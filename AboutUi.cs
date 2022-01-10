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
    public partial class AboutUi : Form
    {
        public AboutUi()
        {
            InitializeComponent();
        }
      
        private void label2_Click(object sender, EventArgs e)
        {
            Ui ui = new Ui();
            this.Visible = false;
        }
    }
}
