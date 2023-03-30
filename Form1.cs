using MySql.Data.MySqlClient;
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

namespace TreesLubo
{
    public partial class Form1 : Form
    {
        string connstr = "server=192.168.1.237;" + "port=3306;" + 
            "user=REMOTE;" + "password=Aa123456@;" +
            "database=trees";
        MySqlConnection connect;
        MySqlCommand query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection now oppening");
        }
    }
}
