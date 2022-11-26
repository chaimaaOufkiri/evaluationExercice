using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace evaluationExercice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        
        private void questionOuverteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void qCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        static string chaine = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Evaluation.accdb";
        static OleDbConnection cnx = new OleDbConnection(chaine);
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(Date Debut , Date Fin) values('" + txtDateDebut.Text + "','" + txtDateFin.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cnx.Close();
        }
    }
}
