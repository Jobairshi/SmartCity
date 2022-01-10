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
    public partial class AddHouseUi : Form
    {
        public AddHouseUi()
        {
            InitializeComponent();
        }
        static void Add(string area, string name, string phone,string link)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();
            // data adapter object is use to
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();
            string s = "insert into rent values('" + area + "','" + name + "','" + phone + "','"+link+ "')";
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
        private void Submit_Click(object sender, EventArgs e)
        {
            string area = AreaName.Texts;
            string name = HouseName.Texts;
            string phone = Phone.Texts;
            string Link = link.Texts;
            Add(area, name, phone, Link);
            Submit.Enabled = false;
        }
    }
}
