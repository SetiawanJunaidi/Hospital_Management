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
    public partial class PatientCheckOut : Form
    {
        public PatientCheckOut()
        {
            InitializeComponent();
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SmartCity\Downloads\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
            string mysqlcon = "server=localhost;user=root;database=hospital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            mySqlConnection.Open();

            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,gen,age,cont,addr,disease from patient where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                MySqlCommand cmd = new MySqlCommand(getCust, mySqlConnection);
                  MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        if (dr[1].ToString() == "Male")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();
                        textBox7.Text = dr.GetValue(5).ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " patient is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (MySqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                mySqlConnection.Close();
            }
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
                string str = "INSERT INTO checkout(name,gen,age,contact,addr,disease,date_in,date_out,build,r_no,r_type,status,med_price,total) VALUES('" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox15.Text + "'); ";

              MySqlCommand cmd = new MySqlCommand(str, mySqlConnection);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from checkout;";

              MySqlCommand cmd1 = new MySqlCommand(str1, mySqlConnection);
              MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Checkout Information Saved Successfully..");
                    textBox2.Text = "";
                    textBox3.Text = "";
                   
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";                    
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

            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }
    }
}
