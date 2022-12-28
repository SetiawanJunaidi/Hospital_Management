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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            mySqlConnection.Open();
            
            
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            try
            {
                string str = "INSERT INTO patient(name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price) VALUES('" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'); ";

              MySqlCommand cmd = new MySqlCommand(str, mySqlConnection);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from patient;";

              MySqlCommand cmd1 = new MySqlCommand(str1, mySqlConnection);
              MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Information Saved Successfully..");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                                   
                }                
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            mySqlConnection.Close();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            mySqlConnection.Open();
            string str1 = "select max(id) from patient;";

        MySqlCommand cmd1 = new MySqlCommand(str1, mySqlConnection);
        MySqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
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
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox1.Text = "";
        }
    }
}
