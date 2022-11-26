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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string chaine = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Evaluation.accdb";
        static OleDbConnection cnx = new OleDbConnection(chaine);
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Question Ouverte(Question) values('" +txtQuestion.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {

            cnx.Close();
        }
    }
}
