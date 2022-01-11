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


namespace SQL_Tur_Retur
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=WIN-0P5QJLRVGFJ;Initial Catalog=Din_mor;User ID=Admin;Password=admin");
        
        
        public Form1()
        {
            InitializeComponent();
            combobreaker();
            display_data();
            display_registrering();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into User_data (Navn,Dato,Nr_plade) values('" + OS_TextBox_Navn.Text + "','" + OS_TextBox_Dato.Text + "','" + OS_TextBox_Nr_plade.Text + "')";

            cmd.ExecuteNonQuery();
            cnn.Close();
            OS_TextBox_Navn.Text = "";
            OS_TextBox_Dato.Text = "";
            OS_TextBox_Nr_plade.Text = "";
            display_data();
            MessageBox.Show("Data Inserted Successfully");
            SS_Combobox.Items.Clear();
            OKL_comboBox.Items.Clear();
            RS_Combobox.Items.Clear();
            combobreaker();
            display_registrering();
        }
        public void display_data()
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Navn, Dato, Nr_plade from User_data";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            cnn.Close();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
                //Opret Stamdata text


        }

        private void OS_TextBox_Navn_TextChanged(object sender, EventArgs e)
        {
            
            
            
            


        }

        private void OS_Navn_Click(object sender, EventArgs e)
        {

        }

        private void OS_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'din_morDataSet.User_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.din_morDataSet.User_data);

        }

        private void OS_TextBox_Dato_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OS_TextBox_Nr_plade_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void RS_Ok_Click(object sender, EventArgs e)
        {
            string newDato = RS_Dato.Text;
            string newNr = RS_Nr_plade.Text;
            string UpdateQuery = "Update User_data SET Nr_plade = '" + newNr + "', Dato ='" + newDato + "'where Navn = '" + RS_Combobox.Text + "'";
            SqlCommand updateCommand = new SqlCommand(UpdateQuery, cnn);
            cnn.Open();
            updateCommand.ExecuteReader();

            cnn.Close();
            combobreaker();
            display_data();
            display_registrering();
        }

        private void SS_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SS_Ok_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from User_data where Navn = '" + SS_Combobox.Text + "'", cnn);
            cnn.Open();
            
                

            cmd.ExecuteNonQuery();
            cnn.Close();
            OS_TextBox_Navn.Text = "";
            OS_TextBox_Dato.Text = "";
            OS_TextBox_Nr_plade.Text = "";
            display_data();
            MessageBox.Show("Data Deleted Successfully");
            combobreaker();
            display_registrering();
        }

        private void RS_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void OKL_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_data();
        }
        private void combobreaker()
        {
            
            SS_Combobox.ResetText();
            SS_Combobox.Items.Clear();
            
            RS_Combobox.ResetText();
            RS_Combobox.Items.Clear();
            
            OKL_comboBox.ResetText();
            OKL_comboBox.Items.Clear();

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User_data";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SS_Combobox.Items.Add(dr["Navn"].ToString());
                RS_Combobox.Items.Add(dr["Navn"].ToString());
                OKL_comboBox.Items.Add(dr["Navn"].ToString());
            }
            cnn.Close();
        }
        public void display_registrering()
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User_data";
            cmd.ExecuteNonQuery();
            DataTable dta2 = new DataTable();
            SqlDataAdapter dataadp2 = new SqlDataAdapter(cmd);
            dataadp2.Fill(dta2);
            dataGridView2.DataSource = dta2;
            cnn.Close();


        }

        private void OKL_Ok_Click(object sender, EventArgs e)
        {
            string newopg = OKL_TextBox_Opg.Text;
            string UpdateQuery = "Update User_data SET Opgave = '" + newopg + "'where Navn = '" + OKL_comboBox.Text + "'";
            SqlCommand updateCommand = new SqlCommand(UpdateQuery, cnn);
            cnn.Open();
            updateCommand.ExecuteReader();
            cnn.Close();
            display_registrering();
            MessageBox.Show("Data Successfully changed");
            SS_Combobox.Items.Clear();
            OKL_comboBox.Items.Clear();
            RS_Combobox.Items.Clear();
            OKL_comboBox.Items.Clear();
            OKL_Texbox_Dato.Clear();
            OKL_Textbox_Nr_plade.Clear();
            OKL_TextBox_Opg.Clear();

            combobreaker();

        }

        private void OKL_Texbox_Dato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
