
namespace evaluationExercice
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creerUnExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionOuverteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnAfficher1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.propositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnExamenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creerUnExamenToolStripMenuItem
            // 
            this.creerUnExamenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionOuverteToolStripMenuItem});
            this.creerUnExamenToolStripMenuItem.Name = "creerUnExamenToolStripMenuItem";
            this.creerUnExamenToolStripMenuItem.Size = new System.Drawing.Size(206, 29);
            this.creerUnExamenToolStripMenuItem.Text = "Creer un Examen QCM";
            // 
            // questionOuverteToolStripMenuItem
            // 
            this.questionOuverteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propositionToolStripMenuItem});
            this.questionOuverteToolStripMenuItem.Name = "questionOuverteToolStripMenuItem";
            this.questionOuverteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.questionOuverteToolStripMenuItem.Text = "Question ";
            this.questionOuverteToolStripMenuItem.Click += new System.EventHandler(this.QuestionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Fin";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(262, 108);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(100, 26);
            this.txtDateDebut.TabIndex = 3;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(262, 163);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(100, 26);
            this.txtDateFin.TabIndex = 4;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(61, 255);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 44);
            this.btnAdd1.TabIndex = 5;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(273, 246);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 53);
            this.btnCancel1.TabIndex = 6;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnAfficher1
            // 
            this.btnAfficher1.Location = new System.Drawing.Point(542, 259);
            this.btnAfficher1.Name = "btnAfficher1";
            this.btnAfficher1.Size = new System.Drawing.Size(140, 36);
            this.btnAfficher1.TabIndex = 7;
            this.btnAfficher1.Text = "Afficher";
            this.btnAfficher1.UseVisualStyleBackColor = true;
            this.btnAfficher1.Click += new System.EventHandler(this.btnAfficher1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(332, 130);
            this.dataGridView1.TabIndex = 8;
            // 
            // propositionToolStripMenuItem
            // 
            this.propositionToolStripMenuItem.Name = "propositionToolStripMenuItem";
            this.propositionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.propositionToolStripMenuItem.Text = "Proposition";
            this.propositionToolStripMenuItem.Click += new System.EventHandler(this.propositionToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(262, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAfficher1);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Evaluation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creerUnExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionOuverteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnAfficher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem propositionToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
    }
}