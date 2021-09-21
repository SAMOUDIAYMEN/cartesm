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
    public partial class affectationForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=cartessim;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        public affectationForm()
        {
            InitializeComponent();
            select();
            selectid_all("id_ligne_affect", "ligne_affectation", cmbligneaffect);
            selectid_all("id_effect", "affectation", cmbIDAffect1);
            selectid_all("id_effect", "affectation", cmbIDAffect2);
            selectid_all("idsim", "cartessim", cmbIDSIM);
            selectid_all("id_NUM", "Numero", cmbIDNumero);
            selectid_all("id_terminal", "Terminaux", cmbIdTerminal);
            selectid_all("id_user", "benificiaires", cmbIDUser);
        }

        private void radioAffectations_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAffectations.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void radioAjoutModifAfc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAjoutModifAfc.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        /*select in mode connecter*/
        void select()
        {
            dataGridView1.Rows.Clear();
            command.CommandText = "select * from ligne_affectation";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                (int)reader[0],
                (int)reader[1],
                (int)reader[2],
                (int)reader[3],
                (int)reader[4]);
            }

            connection.Close();
        }

        /*ajouter in m conn*/
        void ajouter_ligne_affect()
        {
            command.CommandText = $"insert into ligne_affectation values({cmbligneaffect.Text},{cmbIDAffect1.Text},{cmbIDSIM.Text},{cmbIDNumero.Text},{cmbIdTerminal.Text})";
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
                selectid_all("id_ligne_affect", "ligne_affectation", cmbligneaffect);
            }
        }

        /*modifier using transaction*/
        void modifier_ligne_affect()
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = transaction;
            try
            {

                command.CommandText = $"delete from ligne_affectation where id_ligne_affect = {cmbligneaffect.Text}";
                command.ExecuteNonQuery();

                command.CommandText = $"insert into ligne_affectation values({cmbligneaffect.Text},{cmbIDAffect1.Text},{cmbIDSIM.Text},{cmbIDNumero.Text},{cmbIdTerminal.Text})";
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
        void delete_ligne_affect()
        {
            command.CommandText = $"delete from ligne_affectation where id_ligne_affect = {cmbligneaffect.Text}";
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
                selectid_all("id_ligne_affect", "ligne_affectation", cmbligneaffect);
            }
        }

        /*select id_cart*/
        void selectid_all(string column,string table,ComboBox cmbname)
        {
            cmbname.Items.Clear();
            command.CommandText = $"select {column} from {table}";
            command.Connection = connection;

            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbname.Items.Add(reader[0]);
            }

            connection.Close();
        }


        private void btnAjouter1_Click(object sender, EventArgs e)
        {
            ajouter_ligne_affect();
        }

        private void btnModifier1_Click(object sender, EventArgs e)
        {
            modifier_ligne_affect();
        }

        private void btnSupp1_Click(object sender, EventArgs e)
        {
            delete_ligne_affect();
        }

        private void cmbligneaffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = $"select * from ligne_affectation where id_ligne_affect = {cmbligneaffect.SelectedItem}";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbIDAffect1.Text = reader[1].ToString();
                    cmbIDSIM.Text = reader[2].ToString();
                    cmbIDNumero.Text = reader[3].ToString();
                    cmbIdTerminal.Text = reader[4].ToString();
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

        private void cmbIDAffect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = $"select * from affectation where id_effect = {cmbIDAffect2.SelectedItem}";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DatePickerAff.Value = Convert.ToDateTime(reader[1]);
                    cmbIDUser.Text = reader[2].ToString();
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

        void ajouter_affect()
        {
            command.CommandText = $"insert into affectation values({cmbIDAffect2.Text},'{DatePickerAff.Value}',{cmbIDUser.Text})";
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
                selectid_all("id_effect", "affectation", cmbIDAffect1);
                selectid_all("id_effect", "affectation", cmbIDAffect2);
            }
        }

        /*modifier using transaction*/
        void modifier_affect()
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = transaction;
            try
            {

                command.CommandText = $"delete from affectation where id_effect = {cmbIDAffect2.Text}";
                command.ExecuteNonQuery();

                command.CommandText = $"insert into affectation values({cmbIDAffect2.Text},'{DatePickerAff.Value}',{cmbIDUser.Text})";
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
        void delete_affect()
        {
            command.CommandText = $"delete from affectation where id_effect = {cmbIDAffect2.Text}";
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
                selectid_all("id_effect", "affectation", cmbIDAffect1);
                selectid_all("id_effect", "affectation", cmbIDAffect2);
            }
        }

        private void btnAjouter2_Click(object sender, EventArgs e)
        {
            ajouter_affect();
        }

        private void btnModifier2_Click(object sender, EventArgs e)
        {
            modifier_affect();
        }

        private void btnSupprimer2_Click(object sender, EventArgs e)
        {
            delete_affect();
        }
    }
}
