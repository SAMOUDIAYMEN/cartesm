using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartesm
{
    public partial class terminauxForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=cartessim;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        /*select in mode connecter*/
        void select()
        {
            dataGridView1.Rows.Clear();
            command.CommandText = "select * from Terminaux";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                (int)reader[0],
                (string)reader[1],
                (int)reader[2],
                (int)reader[3]);
            }

            connection.Close();
        }

        /*delete in m conn*/
        void delete()
        {
            command.CommandText = $"delete from Terminaux where id_terminal = {cmbIDTerminal.Text}";
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                select();
            }
        }

        /*ajouter in m conn*/
        void ajouter()
        {
            command.CommandText = $"insert into Terminaux values({cmbIDTerminal.Text},'{txtEmei.Text}',{txtSerie.Text},{cmbModel.Text})";
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                select();
            }
        }

        /*modifier using transaction*/
        void modifier()
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = transaction;
            try
            {

                command.CommandText = $"delete from Terminaux where id_terminal = {cmbIDTerminal.Text}";
                command.ExecuteNonQuery();

                command.CommandText = $"insert into Terminaux values({cmbIDTerminal.Text},'{txtEmei.Text}',{txtSerie.Text},{cmbModel.Text})";
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                select();
            }
        }
        /*select model*/
        void selecid_terminal()
        {
            command.CommandText = "select id_terminal from Terminaux";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbIDTerminal.Items.Add(reader[0]);
            }

            connection.Close();
        }
        /*select model*/
        void selectmodel()
        {
            command.CommandText = "select idmodel from Terminaux";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbModel.Items.Add(reader[0]);
            }

            connection.Close();
        }
        public terminauxForm()
        {
            InitializeComponent();
            select();
            selecid_terminal();
            selectmodel();
        }

        private void radioTerminaux_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTerminaux.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void radioAjoutModifTer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAjoutModifTer.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void cmbIDTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = $"select * from Terminaux where id_terminal = {cmbIDTerminal.SelectedItem}";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtEmei.Text = reader[1].ToString();
                    txtSerie.Text = reader[2].ToString();
                    cmbModel.Text = reader[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
