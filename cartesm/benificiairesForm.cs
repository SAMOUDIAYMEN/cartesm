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
    public partial class benificiairesForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=cartessim;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;

        /*select in mode connecter*/
        void select()
        {
            dataGridView1.Rows.Clear();
            command.CommandText = "select * from benificiaires";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                (int)reader[0],
                (string)reader[1],
                (string)reader[2],
                (int)reader[3],
                (int)reader[4],
                (int)reader[5]);
            }

            connection.Close();
        }

        /*delete in m conn*/
        void delete()
        {
            command.CommandText = $"delete from benificiaires where id_user = {cmbIDUser.Text}";
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
            command.CommandText = $"insert into benificiaires values({cmbIDUser.Text},'{txtNom.Text}','{txtPrenom.Text}',{txtMatricule.Text},{cmbDirection.Text},{cmbFonction.Text})";
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

                command.CommandText = $"delete from benificiaires where id_user = {cmbIDUser.Text}";
                command.ExecuteNonQuery();

                command.CommandText = $"insert into benificiaires values({cmbIDUser.Text},'{txtNom.Text}','{txtPrenom.Text}',{txtMatricule.Text},{cmbDirection.Text},{cmbFonction.Text})";
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

        /*select id_user*/
        void selectid_user()
        {
            command.CommandText = "select id_user from benificiaires";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbIDUser.Items.Add(reader[0]);
            }

            connection.Close();
        }

        /*select direction*/
        void selectdirection()
        {
            command.CommandText = "select direc from benificiaires";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDirection.Items.Add(reader[0]);
            }

            connection.Close();
        }

        /*select fonction*/
        void selectfonction()
        {
            command.CommandText = "select fonct from benificiaires";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbFonction.Items.Add(reader[0]);
            }

            connection.Close();
        }

        public benificiairesForm()
        {
            InitializeComponent();
            select();
            selectid_user();
            selectdirection();
            selectfonction();
        }

        private void radioBenificiaires_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBenificiaires.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void radioAjoutModif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAjoutModif.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajouter();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void cmbIDUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = $"select * from benificiaires where id_user = {cmbIDUser.SelectedItem}";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtNom.Text = reader[1].ToString();
                    txtPrenom.Text = reader[2].ToString();
                    txtMatricule.Text = reader[3].ToString();
                    cmbDirection.Text = reader[4].ToString();
                    cmbFonction.Text = reader[5].ToString();
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
