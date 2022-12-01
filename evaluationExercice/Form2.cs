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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static string chaine = @" Data Source=DESKTOP-6C4KUDE\SQLEXPRESS;Initial Catalog=ExerciceEvaluation;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(id, dateDebut , dateFin) values('"+txtId.Text+"','" + txtDateDebut.Text+ "','" +txtDateFin.Text+ "')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(id, dateDebut , dateFin) values('" + txtId.Text + "','" + txtDateDebut.Text + "','" + txtDateFin.Text + "')";
            cnx.Close();
        }

        private void btnAfficher1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Examen ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void QuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myform = new Form3();
            myform.Show();
        }

        private void propositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myform = new Form4();
            myform.Show();
        }
    }
}
