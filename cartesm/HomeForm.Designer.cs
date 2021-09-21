
namespace cartesm
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benificiareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartesSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(950, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benificiareToolStripMenuItem,
            this.terminauxToolStripMenuItem,
            this.cartesSIMToolStripMenuItem,
            this.numerosToolStripMenuItem,
            this.affectationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benificiareToolStripMenuItem
            // 
            this.benificiareToolStripMenuItem.Name = "benificiareToolStripMenuItem";
            this.benificiareToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.benificiareToolStripMenuItem.Text = "Benificiares";
            this.benificiareToolStripMenuItem.Click += new System.EventHandler(this.benificiareToolStripMenuItem_Click);
            // 
            // terminauxToolStripMenuItem
            // 
            this.terminauxToolStripMenuItem.Name = "terminauxToolStripMenuItem";
            this.terminauxToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.terminauxToolStripMenuItem.Text = "Terminaux";
            this.terminauxToolStripMenuItem.Click += new System.EventHandler(this.terminauxToolStripMenuItem_Click);
            // 
            // cartesSIMToolStripMenuItem
            // 
            this.cartesSIMToolStripMenuItem.Name = "cartesSIMToolStripMenuItem";
            this.cartesSIMToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cartesSIMToolStripMenuItem.Text = "Cartes SIM";
            this.cartesSIMToolStripMenuItem.Click += new System.EventHandler(this.cartesSIMToolStripMenuItem_Click);
            // 
            // numerosToolStripMenuItem
            // 
            this.numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            this.numerosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.numerosToolStripMenuItem.Text = "Numeros";
            this.numerosToolStripMenuItem.Click += new System.EventHandler(this.numerosToolStripMenuItem_Click);
            // 
            // affectationToolStripMenuItem
            // 
            this.affectationToolStripMenuItem.Name = "affectationToolStripMenuItem";
            this.affectationToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.affectationToolStripMenuItem.Text = "Affectation";
            this.affectationToolStripMenuItem.Click += new System.EventHandler(this.affectationToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 605);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem benificiareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartesSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectationToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}