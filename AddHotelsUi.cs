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
    public partial class AddHotelsUi : Form
    {
        public AddHotelsUi()
        {
            InitializeComponent();
        }
        static void AddHotels(string area, string name,string price, string phone, string link)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();
            // data adapter object is use to
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();
            string s = "insert into hotel values('" + area + "','" + name + "','" + price + "','" + phone + "','" + link + "')";
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
        private void Add_Click(object sender, EventArgs e)
        {
            string area = AreaName.Texts;
            string name = hotelName.Texts;
            string Price = price.Texts;
            string phone = Phone.Texts;
            string Link = link.Texts;
            AddHotels(area, name, Price, phone, Link);
            Add.Enabled = false;
        }
    }
}
