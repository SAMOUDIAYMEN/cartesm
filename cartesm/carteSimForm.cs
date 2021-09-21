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
    public partial class carteSimForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=cartessim;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        public carteSimForm()
        {
            InitializeComponent();
            select();
            selectid_cart();
        }

        /*select in mode connecter*/
        void select()
        {
            dataGridView1.Rows.Clear();
            command.CommandText = "select * from cartessim";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                (int)reader[0],
                (string)reader[1]);
            }

            connection.Close();
        }

        /*ajouter in m conn*/
        void ajouter()
        {
            command.CommandText = $"insert into cartessim values({cmbSimID.Text},'{txtNumSerie.Text}')";
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

                command.CommandText = $"delete from cartessim where idsim = {cmbSimID.Text}";
                command.ExecuteNonQuery();

                command.CommandText = $"insert into cartessim values({cmbSimID.Text},'{txtNumSerie.Text}')";
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

        /*delete in m conn*/
        void delete()
        {
            command.CommandText = $"delete from cartessim where idsim = {cmbSimID.Text}";
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

        /*select id_cart*/
        void selectid_cart()
        {
            command.CommandText = "select idsim from cartessim";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbSimID.Items.Add(reader[0]);
            }

            connection.Close();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            ajouter();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            modifier();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            delete();
        }

        private void cmbSimID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = $"select * from cartessim where idsim = {cmbSimID.SelectedItem}";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtNumSerie.Text = reader[1].ToString();
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
