
namespace cartesm
{
    partial class benificiairesForm
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
            this.radioBenificiaires = new System.Windows.Forms.RadioButton();
            this.radioAjoutModif = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbFonction = new System.Windows.Forms.ComboBox();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.cmbIDUser = new System.Windows.Forms.ComboBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBenificiaires
            // 
            this.radioBenificiaires.AutoSize = true;
            this.radioBenificiaires.Checked = true;
            this.radioBenificiaires.Location = new System.Drawing.Point(326, 37);
            this.radioBenificiaires.Name = "radioBenificiaires";
            this.radioBenificiaires.Size = new System.Drawing.Size(97, 17);
            this.radioBenificiaires.TabIndex = 0;
            this.radioBenificiaires.TabStop = true;
            this.radioBenificiaires.Text = "les Benificiaires";
            this.radioBenificiaires.UseVisualStyleBackColor = true;
            this.radioBenificiaires.CheckedChanged += new System.EventHandler(this.radioBenificiaires_CheckedChanged);
            // 
            // radioAjoutModif
            // 
            this.radioAjoutModif.AutoSize = true;
            this.radioAjoutModif.Location = new System.Drawing.Point(553, 37);
            this.radioAjoutModif.Name = "radioAjoutModif";
            this.radioAjoutModif.Size = new System.Drawing.Size(145, 17);
            this.radioAjoutModif.TabIndex = 1;
            this.radioAjoutModif.Text = "Ajout/Modifier Benificiaire";
            this.radioAjoutModif.UseVisualStyleBackColor = true;
            this.radioAjoutModif.CheckedChanged += new System.EventHandler(this.radioAjoutModif_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(36, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 498);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.nom,
            this.prenom,
            this.matricule,
            this.direc,
            this.fonct});
            this.dataGridView1.Location = new System.Drawing.Point(37, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSupprimer);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Controls.Add(this.cmbFonction);
            this.groupBox2.Controls.Add(this.cmbDirection);
            this.groupBox2.Controls.Add(this.cmbIDUser);
            this.groupBox2.Controls.Add(this.txtMatricule);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(53, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 498);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSupprimer.Location = new System.Drawing.Point(369, 433);
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
            this.btnModifier.Location = new System.Drawing.Point(369, 397);
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
            this.btnAjouter.Location = new System.Drawing.Point(369, 361);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(240, 30);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbFonction
            // 
            this.cmbFonction.FormattingEnabled = true;
            this.cmbFonction.Location = new System.Drawing.Point(369, 312);
            this.cmbFonction.Name = "cmbFonction";
            this.cmbFonction.Size = new System.Drawing.Size(240, 21);
            this.cmbFonction.TabIndex = 11;
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Location = new System.Drawing.Point(369, 261);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(240, 21);
            this.cmbDirection.TabIndex = 10;
            // 
            // cmbIDUser
            // 
            this.cmbIDUser.FormattingEnabled = true;
            this.cmbIDUser.Location = new System.Drawing.Point(369, 51);
            this.cmbIDUser.Name = "cmbIDUser";
            this.cmbIDUser.Size = new System.Drawing.Size(240, 21);
            this.cmbIDUser.TabIndex = 9;
            this.cmbIDUser.SelectedIndexChanged += new System.EventHandler(this.cmbIDUser_SelectedIndexChanged);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(369, 210);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(240, 20);
            this.txtMatricule.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(369, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(240, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(369, 108);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(240, 20);
            this.txtNom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fonction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID User";
            // 
            // id_user
            // 
            this.id_user.HeaderText = "id_user";
            this.id_user.Name = "id_user";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // matricule
            // 
            this.matricule.HeaderText = "matricule";
            this.matricule.Name = "matricule";
            // 
            // direc
            // 
            this.direc.HeaderText = "direc";
            this.direc.Name = "direc";
            // 
            // fonct
            // 
            this.fonct.HeaderText = "fonct";
            this.fonct.Name = "fonct";
            // 
            // benificiairesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1007, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioAjoutModif);
            this.Controls.Add(this.radioBenificiaires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "benificiairesForm";
            this.Text = "benificiairesForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBenificiaires;
        private System.Windows.Forms.RadioButton radioAjoutModif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFonction;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.ComboBox cmbIDUser;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonct;
    }
}