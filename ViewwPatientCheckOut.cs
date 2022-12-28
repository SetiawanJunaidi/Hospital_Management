using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystemCSharp
{
    public partial class ViewwPatientCheckOut : Form
    {
        public ViewwPatientCheckOut()
        {
            InitializeComponent();
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void ViewwPatientCheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet3.checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter.Fill(this.hospitalDataSet3.checkout);
        // using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
        string mysqlcon = "server=localhost;user=root;database=hospital;password=";
   MySqlConnection mySqlConnection1= new MySqlConnection(mysqlcon);
            {

                string str2 = "SELECT * FROM checkout";
            MySqlCommand cmd2 = new MySqlCommand(str2, mySqlConnection1);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection1 = new MySqlConnection(mysqlcon);
            {

                string str2 = "SELECT * FROM checkout where id='"+textBox1.Text +"'";
              MySqlCommand cmd2 = new MySqlCommand(str2, mySqlConnection1);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
