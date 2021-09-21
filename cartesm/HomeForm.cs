using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartesm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void benificiareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            benificiairesForm bf = new benificiairesForm();
            openChildForm(bf);
        }


        private Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void terminauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminauxForm bf = new terminauxForm();
            openChildForm(bf);
        }

        private void cartesSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carteSimForm bf = new carteSimForm();
            openChildForm(bf);
        }

        private void numerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telephoneForm bf = new telephoneForm();
            openChildForm(bf);
        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affectationForm bf = new affectationForm();
            openChildForm(bf);
        }
    }
}
