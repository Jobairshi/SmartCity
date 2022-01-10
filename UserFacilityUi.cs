using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCity
{
    public partial class UserFacilityUi : Form
    {
        public UserFacilityUi()
        {
            InitializeComponent();
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
        
    
        private void TransButton_Click(object sender, EventArgs e)
        {
            if(slidePan.Visible == false)
            slidePan.Visible = true;
            else 
                slidePan.Visible = false;
            RentButton.Enabled = true;
            HotelButton.Enabled = true;
            HospitalButton.Enabled = true;
            EmerButton.Enabled = true;
            TransButton.Enabled = true;
        }

        private void RentButton_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RentUi());
            RentButton.Enabled = false;
            HotelButton.Enabled = true;
            HospitalButton.Enabled = true;  
            EmerButton.Enabled = true;  
            TransButton.Enabled = true;
          //  RentButton.BackColor = Color.Aqua;
            // this.Visible=false;
        }

        private void HotelButton_Click_1(object sender, EventArgs e)
        {
            RentButton.Enabled = true;
            HotelButton.Enabled = false;
            HospitalButton.Enabled = true;
            EmerButton.Enabled = true;
            TransButton.Enabled = true;
            openChildForm(new HotelUi());
        }

        private void HospitalButton_Click_1(object sender, EventArgs e)
        {
            RentButton.Enabled = true;
            HotelButton.Enabled = true;
            HospitalButton.Enabled = false;
            EmerButton.Enabled = true;
            TransButton.Enabled = true;
            openChildForm(new HospitalUi());
        }

        
        private void Back_Click(object sender, EventArgs e)
        {

            UserUi obj = new UserUi();
            //   obj.Show(); 
            this.Visible = false;
        }

        private void EmerButton_Click(object sender, EventArgs e)
        {
           /* if (sidepan.Visible == false)
                sidepan.Visible = true;
            else
                sidepan.Visible = false;*/
           openChildForm(new EmergencyUi());
            RentButton.Enabled = true;
            HotelButton.Enabled = true;
            HospitalButton.Enabled = true;
            EmerButton.Enabled = true;
            TransButton.Enabled = true;
        }

        private void Train_Click(object sender, EventArgs e)
        {
            openChildForm(new TransportUi());
        }

       
        private void Police_Click(object sender, EventArgs e)
        {
            openChildForm(new EmergencyUi());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new EmergencyUi());
        }

        private void Blood_Click(object sender, EventArgs e)
        {
            openChildForm(new EmergencyUi());
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(activeForm != null)  
            activeForm.Close();
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
        private void Uber_Click(object sender, EventArgs e)
        {
            string url = "https://www.uber.com/bd/en/";
            OpenUrl(url);
        }

        private void Patao_Click(object sender, EventArgs e)
        {
            string url = "https://pathao.com/bn/";
            OpenUrl(url);
        }
    }
}
