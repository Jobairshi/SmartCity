using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCity
{
    public partial class HotelUi : Form
    {
        public HotelUi()
        {
            InitializeComponent();
        }
        public List<string> areas = new List<string>();
        public Button[] buttons = new Button[100];
        public Label[] labels = new Label[100];
        public Label[] phones = new Label[100];
        public Label[] prices = new Label[100];
        public List<string> Links = new List<string>();
        public void ClickButton(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            //   MessageBox.Show("You clicked character [" + btn.Name +"]");
            string s = btn.Name;
            int i = s[0] - '0';
            s = Links[i];
            OpenUrl(s);
        }
        public int addToCombo()
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            SqlDataReader dreader;
            string sql;
            conn = new SqlConnection(constr);
            conn.Open();

            sql = "Select area,name,price,phone,link from hotel";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            int i = 0;
            while (dreader.Read())
            {
                string ar = dreader.GetString(0);
                areas.Add(ar);
                i++;
            }
            dreader.Close();
            cmd.Dispose();
            conn.Close();
            return i;
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
        public void Connect_Check(string area)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            SqlDataReader dreader;
            string sql;
            conn = new SqlConnection(constr);
            conn.Open();

            sql = "Select area,name,price,phone,link from hotel";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            int i = 0;
            while (dreader.Read())
            {
                // output = output + dreader.GetValue(0) + " - " +
                //                   dreader.GetValue(1) + "\n";
                string ar = dreader.GetString(0);
                string nm = dreader.GetString(1);
                string pri = dreader.GetString(2);
                string phn  = dreader.GetString(3);
                string link = dreader.GetString(4);
                if (ar == area)
                {
                    Links.Add(link);
                    labels[i].Text = nm;
                    labels[i].Visible = true;
                    buttons[i].Visible = true;
                    buttons[i].Text = nm;
                    prices[i].Visible = true;
                    prices[i].Text = pri;
                    phones[i].Visible = true;
                    phones[i].Text = phn;
                    buttons[i].Name = i.ToString();
                    i++;

                }
            }
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
        private void HotelUi_Load(object sender, EventArgs e)
        {
            int count = addToCombo();
            for (var i = 0; i < areas.Count; i++)
            {
                CityBox.Items.Add(areas[i]);
            }
            for (int i = 0; i < count; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = "Go to Location";
                buttons[i].Size = new Size(200, 40);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].Font = new Font("Century", 13);
                buttons[i].Visible = false;
                buttons[i].Dock = DockStyle.Top;
                buttons[i].Click += new System.EventHandler(ClickButton);
                buttons[i].FlatAppearance.BorderColor = Color.White;
                buttons[i].BackColor = Color.CadetBlue;
                ButtonPanel.Controls.Add(buttons[i]);
            }
            for (int i = 0; i < count; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = false;
                labels[i].Size = new Size(406, 40);
                labels[i].Font = new Font("Century", 13);
                labels[i].TextAlign = ContentAlignment.MiddleLeft;
                labels[i].Visible = false;
                labels[i].Dock = DockStyle.Top;
                labels[i].BorderStyle = BorderStyle.Fixed3D;
                labels[i].BackColor = Color.CadetBlue;
                NamePanel.Controls.Add(labels[i]);
            }
            for (int i = 0; i < count; i++)
            {
                prices[i] = new Label();
                prices[i].AutoSize = false;
                prices[i].Size = new Size(406, 40);
                prices[i].Font = new Font("Century", 13);
                prices[i].TextAlign = ContentAlignment.MiddleLeft;
                prices[i].Visible = false;
                prices[i].Dock = DockStyle.Top;
                prices[i].BorderStyle = BorderStyle.Fixed3D;
                prices[i].BackColor = Color.CadetBlue;
                Prices.Controls.Add(prices[i]);
            }
            for (int i = 0; i < count; i++)
            {
                phones[i] = new Label();
                phones[i].AutoSize = false;
                phones[i].Size = new Size(392, 40);
                phones[i].Font = new Font("Century", 13);
                phones[i].TextAlign = ContentAlignment.MiddleLeft;
                phones[i].Visible = false;
                phones[i].Dock = DockStyle.Top;
                phones[i].BackColor = Color.CadetBlue;
                phones[i].BorderStyle = BorderStyle.Fixed3D;
                Phone.Controls.Add(phones[i]);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string area = CityBox.Texts;
            Connect_Check(area);
        }
    }
}
