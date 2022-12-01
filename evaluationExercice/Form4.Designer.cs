
namespace evaluationExercice
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.txtProposition1 = new System.Windows.Forms.TextBox();
            this.txtProposition2 = new System.Windows.Forms.TextBox();
            this.txtProposition3 = new System.Windows.Forms.TextBox();
            this.btnAfficher3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proposition 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proposition 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proposition 3";
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(60, 258);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(97, 63);
            this.btnAdd3.TabIndex = 5;
            this.btnAdd3.Text = "Add";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(327, 258);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 63);
            this.btnCancel3.TabIndex = 6;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // txtProposition1
            // 
            this.txtProposition1.Location = new System.Drawing.Point(171, 16);
            this.txtProposition1.Name = "txtProposition1";
            this.txtProposition1.Size = new System.Drawing.Size(262, 26);
            this.txtProposition1.TabIndex = 8;
            // 
            // txtProposition2
            // 
            this.txtProposition2.Location = new System.Drawing.Point(171, 81);
            this.txtProposition2.Name = "txtProposition2";
            this.txtProposition2.Size = new System.Drawing.Size(262, 26);
            this.txtProposition2.TabIndex = 9;
            // 
            // txtProposition3
            // 
            this.txtProposition3.Location = new System.Drawing.Point(171, 156);
            this.txtProposition3.Name = "txtProposition3";
            this.txtProposition3.Size = new System.Drawing.Size(262, 26);
            this.txtProposition3.TabIndex = 10;
            // 
            // btnAfficher3
            // 
            this.btnAfficher3.Location = new System.Drawing.Point(627, 220);
            this.btnAfficher3.Name = "btnAfficher3";
            this.btnAfficher3.Size = new System.Drawing.Size(75, 57);
            this.btnAfficher3.TabIndex = 11;
            this.btnAfficher3.Text = "Afficher";
            this.btnAfficher3.UseVisualStyleBackColor = true;
            this.btnAfficher3.Click += new System.EventHandler(this.btnAfficher3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(495, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(293, 165);
            this.dataGridView3.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnAfficher3);
            this.Controls.Add(this.txtProposition3);
            this.Controls.Add(this.txtProposition2);
            this.Controls.Add(this.txtProposition1);
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.TextBox txtProposition1;
        private System.Windows.Forms.TextBox txtProposition2;
        private System.Windows.Forms.TextBox txtProposition3;
        private System.Windows.Forms.Button btnAfficher3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}