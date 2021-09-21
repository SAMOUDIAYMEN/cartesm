
namespace cartesm
{
    partial class terminauxForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbIDTerminal = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtEmei = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioAjoutModifTer = new System.Windows.Forms.RadioButton();
            this.radioTerminaux = new System.Windows.Forms.RadioButton();
            this.id_terminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSupprimer);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Controls.Add(this.cmbModel);
            this.groupBox2.Controls.Add(this.cmbIDTerminal);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.txtEmei);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 498);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            this.groupBox2.Visible = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSupprimer.Location = new System.Drawing.Point(372, 366);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(240, 30);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModifier.Location = new System.Drawing.Point(372, 330);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(240, 30);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouter.Location = new System.Drawing.Point(372, 294);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(240, 30);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(372, 238);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(240, 21);
            this.cmbModel.TabIndex = 10;
            // 
            // cmbIDTerminal
            // 
            this.cmbIDTerminal.FormattingEnabled = true;
            this.cmbIDTerminal.Location = new System.Drawing.Point(372, 79);
            this.cmbIDTerminal.Name = "cmbIDTerminal";
            this.cmbIDTerminal.Size = new System.Drawing.Size(240, 21);
            this.cmbIDTerminal.TabIndex = 9;
            this.cmbIDTerminal.SelectedIndexChanged += new System.EventHandler(this.cmbIDTerminal_SelectedIndexChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(372, 187);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(240, 20);
            this.txtSerie.TabIndex = 7;
            // 
            // txtEmei
            // 
            this.txtEmei.Location = new System.Drawing.Point(372, 136);
            this.txtEmei.Name = "txtEmei";
            this.txtEmei.Size = new System.Drawing.Size(240, 20);
            this.txtEmei.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emei";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Terminal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(53, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 498);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_terminal,
            this.imei,
            this.serieterm,
            this.idmodel});
            this.dataGridView1.Location = new System.Drawing.Point(37, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // radioAjoutModifTer
            // 
            this.radioAjoutModifTer.AutoSize = true;
            this.radioAjoutModifTer.Location = new System.Drawing.Point(554, 27);
            this.radioAjoutModifTer.Name = "radioAjoutModifTer";
            this.radioAjoutModifTer.Size = new System.Drawing.Size(138, 17);
            this.radioAjoutModifTer.TabIndex = 6;
            this.radioAjoutModifTer.Text = "Ajout/Modifier Terminau";
            this.radioAjoutModifTer.UseVisualStyleBackColor = true;
            this.radioAjoutModifTer.CheckedChanged += new System.EventHandler(this.radioAjoutModifTer_CheckedChanged);
            // 
            // radioTerminaux
            // 
            this.radioTerminaux.AutoSize = true;
            this.radioTerminaux.Checked = true;
            this.radioTerminaux.Location = new System.Drawing.Point(327, 27);
            this.radioTerminaux.Name = "radioTerminaux";
            this.radioTerminaux.Size = new System.Drawing.Size(90, 17);
            this.radioTerminaux.TabIndex = 5;
            this.radioTerminaux.TabStop = true;
            this.radioTerminaux.Text = "les Terminaux";
            this.radioTerminaux.UseVisualStyleBackColor = true;
            this.radioTerminaux.CheckedChanged += new System.EventHandler(this.radioTerminaux_CheckedChanged);
            // 
            // id_terminal
            // 
            this.id_terminal.HeaderText = "id_terminal";
            this.id_terminal.Name = "id_terminal";
            // 
            // imei
            // 
            this.imei.HeaderText = "imei";
            this.imei.Name = "imei";
            // 
            // serieterm
            // 
            this.serieterm.HeaderText = "serieterm";
            this.serieterm.Name = "serieterm";
            // 
            // idmodel
            // 
            this.idmodel.HeaderText = "idmodel";
            this.idmodel.Name = "idmodel";
            // 
            // terminauxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1007, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioAjoutModifTer);
            this.Controls.Add(this.radioTerminaux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "terminauxForm";
            this.Text = "terminauxForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbIDTerminal;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtEmei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioAjoutModifTer;
        private System.Windows.Forms.RadioButton radioTerminaux;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodel;
    }
}