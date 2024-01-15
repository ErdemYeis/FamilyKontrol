using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FamilyKontrol
{
    public partial class ParentForm : Form
    {
        string cmail;
        string connectionString = @"Data Source=DESKTOP-HOOKELP\SQLEXPRESS;Initial Catalog=FamilyControl;Integrated Security=True";
        int x = 0;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            LoadPasTable();
            string name;
            string query = "SELECT ParentName FROM ParentTable WHERE ParentMail = @mail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@mail", Properties.Settings.Default.ParentMail);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            name = reader["ParentName"].ToString();
                            lblHello.Text = "Merhaba, " + name;
                        }
                        else
                        {
                            name = "-";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını göster
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void btnAccesRequest_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO AccesTable (RequesterMail, ReceiverMail) VALUES  (@rqmail, @rcmail)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rqmail", Properties.Settings.Default.ParentMail);
                    command.Parameters.AddWithValue("@rcmail", txtRMail.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Bilgilendirme Penceresi", "Bağlantı İsteğiniz Gönderilmiştir.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            RefreshCombobox();
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            RefreshCombobox();
        }
        private void RefreshCombobox()
        {
            int parentID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // ParentID'yi al
                    string queryID = "SELECT ParentID FROM ParentTable WHERE ParentMail = @mail";
                    using (SqlCommand commandID = new SqlCommand(queryID, connection))
                    {
                        commandID.Parameters.AddWithValue("@mail", Properties.Settings.Default.ParentMail);
                        parentID = (int)commandID.ExecuteScalar();
                    }

                    // Child maillerini al
                    string query = "SELECT ChildTable.ChildMail FROM ChildTable INNER JOIN LinkedAccounts ON ChildTable.ChildID = LinkedAccounts.ChildID WHERE LinkedAccounts.ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", parentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string childMail = reader["ChildMail"].ToString();

                                // Eğer ComboBox'ta bu değer yoksa ekle
                                if (!comboBox1.Items.Contains(childMail))
                                {
                                    comboBox1.Items.Add(childMail);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            cmail = comboBox1.Text;
            lblEposta.Text = cmail;
            lblEposta.Location = new Point(160,42);
        }

        private void btnTimeAccept_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(txtTime.Text, out time))
            {
                if (lblEposta.Text != "-")
                {
                    string cmail = lblEposta.Text; // Eposta adresi
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        //*
                        using (SqlCommand cmdif = new SqlCommand("SELECT COUNT(*) from ResTable WHERE ChildMail=@cmail", connection))
                        {
                            cmdif.Parameters.AddWithValue("@cmail", cmail);
                            int count = (int)cmdif.ExecuteScalar();
                            if (count <= 0)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO ResTable (ChildMail,ResTime) values (@cmail,@rtime)", connection))
                                {
                                    cmd.Parameters.AddWithValue("@cmail", cmail);
                                    cmd.Parameters.AddWithValue("@rtime", time);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Zaman Kısıtlanması Eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }//*
                    }
                }
                else
                {
                    MessageBox.Show("Hesap Seçiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Geçersiz zaman değeri.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible)
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible)
            {
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
            }
            int parentID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // ParentID'yi al
                    string queryID = "SELECT ParentID FROM ParentTable WHERE ParentMail = @mail";
                    using (SqlCommand commandID = new SqlCommand(queryID, connection))
                    {
                        commandID.Parameters.AddWithValue("@mail", Properties.Settings.Default.ParentMail);
                        parentID = (int)commandID.ExecuteScalar();
                    }

                    // Child maillerini al
                    string query = "SELECT ChildTable.ChildMail FROM ChildTable INNER JOIN LinkedAccounts ON ChildTable.ChildID = LinkedAccounts.ChildID WHERE LinkedAccounts.ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", parentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string childMail = reader["ChildMail"].ToString();

                                // Eğer ComboBox'ta bu değer yoksa ekle
                                if (!cmbMail.Items.Contains(childMail))
                                {
                                    cmbMail.Items.Add(childMail);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            LoadPasTable();
            if (x==1)
            {
                x = 0;
            }
            else
            {
                x = 0;
            }
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            LoadAppWithDate();
            if (x == 1)
            {
                x = 1;
            }
            else
            {
                x = 1;
            }
        }

        private void LoadPasTable()
        {
            string query = "SELECT * FROM PasTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataView.DataSource = dataTable;
            }
            
        }

        private void LoadAppWithDate()
        {
            string query = "SELECT * FROM AppWithDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataView.DataSource = dataTable;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // ComboBox ve DateTimePicker'dan seçilen değerleri alın
            string selectedValue = cmbMail.SelectedItem?.ToString();
            DateTime selectedDate = datePicker.Value.Date;

            // DataGridView'i seçilen değerlere göre filtrelemek için işlevi çağırın
            FilterDataGridView(selectedValue, selectedDate);
        }

        private void FilterDataGridView(string selectedValue, DateTime selectedDate)
        {
            string query = null;
            if (x==0)
            {
                query = "SELECT * FROM PasTable WHERE Childmail = @Selectedmail AND Date = @SelectedDate";
            }
            else if (x==1)
            {
                query = "SELECT * FROM AppWithDate WHERE ChildMail = @Selectedmail AND Date = @SelectedDate";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Selectedmail", selectedValue);
                adapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", selectedDate);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataView.DataSource = dataTable;
            }
        }
    }
}
