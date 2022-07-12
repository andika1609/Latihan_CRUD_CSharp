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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V0NETGE\SQLEXPRESS;Initial Catalog=USER_TABLE;Integrated Security=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO member(ID,Name,Age) VALUES (@ID,@Name,@Age)");
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Succes");

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=USER_TABLE;Integrated Security=False;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE member SET Name=@Name,Age=@Age WHERE ID=@ID)");
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Succesfuly Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=USER_TABLE;Integrated Security=False;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE member WHERE ID=@ID)");
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Succesfuly Deleted");
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSER_TABLEDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.uSER_TABLEDataSet.member);
            
            /*
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=USER_TABLE;Integrated Security=False;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member)");
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=USER_TABLE;Integrated Security=False;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member WHERE ID=@ID)");
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
