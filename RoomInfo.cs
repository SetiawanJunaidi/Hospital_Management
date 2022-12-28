using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace HospitalManagementSystemCSharp
{
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet2.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hospitalDataSet2.room);
            //using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection1= new MySqlConnection(mysqlcon);
            {

                string str2 = "SELECT * FROM room";
              MySqlCommand cmd2 = new MySqlCommand(str2, mySqlConnection1);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            mySqlConnection.Open();
           
            try
            {
                string str = "INSERT INTO room(building,r_type,r_no,no_bed,price,r_status) VALUES('" + textBox1.Text + "','" + textBox2.Text  + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                MySqlCommand cmd = new MySqlCommand(str, mySqlConnection);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from room;";

                MySqlCommand cmd1 = new MySqlCommand(str1, mySqlConnection);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("room Information Saved Successfully..");
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    //using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
                    
                    MySqlConnection mySqlConnection1 = new MySqlConnection(mysqlcon);
                    {

                        string str2 = "SELECT * FROM room";
                        MySqlCommand cmd2 = new MySqlCommand(str2, mySqlConnection1);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            mySqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
