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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        static string chaine = @" Data Source=DESKTOP-6C4KUDE\SQLEXPRESS;Initial Catalog=ExerciceEvaluation;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Proposition( question,choix1, choix2, choix3) values('','" + txtProposition1.Text + "','" + txtProposition2.Text + "','" + txtProposition3.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Proposition( question,choix1, choix2, choix3) values('','" + txtProposition1.Text + "','" + txtProposition2.Text + "','" + txtProposition3.Text + "') ";
            cnx.Close();
        }
        
        private void btnAfficher3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Proposition ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
        }
    }
}
