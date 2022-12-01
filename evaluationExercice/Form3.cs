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


namespace evaluationExercice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string chaine = @"Data Source=DESKTOP-6C4KUDE\SQLEXPRESS;Initial Catalog=ExerciceEvaluation;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Question(id,question) values('" + txtId.Text + "','" + txtQuestion.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Question(id,question) values('" + txtId.Text + "','" + txtQuestion.Text + "') ";
            cnx.Close();
        }

        private void btnAfficher2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Question ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

      

        private void propositionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var myform = new Form4();
            myform.Show();
        }
    }
}
