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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Admin" && txtPassword.Text == "Admin")
            {
                HomeForm f1 = new HomeForm();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Login or Password incorrect!");
        }
    }
}
