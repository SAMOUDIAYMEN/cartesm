
namespace cartesm
{
    partial class telephoneForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbIDNum = new System.Windows.Forms.ComboBox();
            this.txtNumTele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Location = new System.Drawing.Point(425, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 488);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.cmbIDNum);
            this.groupBox1.Controls.Add(this.txtNumTele);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(495, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 499);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout/Modif/Supp";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSupprimer.Location = new System.Drawing.Point(88, 351);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(240, 30);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModifier.Location = new System.Drawing.Point(88, 315);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(240, 30);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouter.Location = new System.Drawing.Point(88, 279);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(240, 30);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbIDNum
            // 
            this.cmbIDNum.FormattingEnabled = true;
            this.cmbIDNum.Location = new System.Drawing.Point(88, 133);
            this.cmbIDNum.Name = "cmbIDNum";
            this.cmbIDNum.Size = new System.Drawing.Size(240, 21);
            this.cmbIDNum.TabIndex = 18;
            this.cmbIDNum.SelectedIndexChanged += new System.EventHandler(this.cmbIDNum_SelectedIndexChanged);
            // 
            // txtNumTele
            // 
            this.txtNumTele.Location = new System.Drawing.Point(88, 193);
            this.txtNumTele.Name = "txtNumTele";
            this.txtNumTele.Size = new System.Drawing.Size(240, 20);
            this.txtNumTele.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero Telephone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_NUM,
            this.numtelf});
            this.dataGridView1.Location = new System.Drawing.Point(107, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 464);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste Numeros Tele:";
            // 
            // id_NUM
            // 
            this.id_NUM.HeaderText = "id_NUM";
            this.id_NUM.Name = "id_NUM";
            // 
            // numtelf
            // 
            this.numtelf.HeaderText = "numtelf";
            this.numtelf.Name = "numtelf";
            // 
            // telephoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1007, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telephoneForm";
            this.Text = "telephoneForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbIDNum;
        private System.Windows.Forms.TextBox txtNumTele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtelf;
    }
}