using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyKontrol
{
    public partial class ChildForm : Form
    {
        private int hour, minute, second;
        string connectionString = @"Data Source=DESKTOP-HOOKELP\SQLEXPRESS;Initial Catalog=FamilyControl;Integrated Security=True";
        string RequesterMail;
        string ParentID, ChildID;

        string[] appNamess;
        public ChildForm()
        {
            InitializeComponent();

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            timer2 = new Timer();
            timer2.Interval = 2000;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();

            saver = new Timer();
            saver.Interval = 5000;
            saver.Enabled = true;
            saver.Tick += new EventHandler(saver_Tick);
            saver.Start();
            string name;
            string query = "SELECT ChildName FROM ChildTable WHERE ChildMail = @mail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@mail", Properties.Settings.Default.ChildMail);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            name = reader["ChildName"].ToString();
                            lblHello.Text = "Merhaba, " + name;
                        }
                        else
                        {
                            name = "-";
                        }

                        reader.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını göster
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
                using (SqlCommand cmdif = new SqlCommand("SELECT COUNT(*) from ResTable WHERE ChildMail=@cmail", connection))
                {
                    cmdif.Parameters.AddWithValue("@cmail", Properties.Settings.Default.ChildMail);
                    connection.Open();
                    int count = (int)cmdif.ExecuteScalar();
                    connection.Close();
                    if (count > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT ResTime FROM ResTable WHERE ChildMail=@cmail", connection))
                        {
                            cmd.Parameters.AddWithValue("@cmail", Properties.Settings.Default.ChildMail);
                            connection.Open();
                            object result = cmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                DateTime ilkGirisTarihi = Properties.Settings.Default.FirstLoginDate;

                                if (ilkGirisTarihi == DateTime.MinValue)
                                {
                                    Properties.Settings.Default.FirstLoginDate = DateTime.Today;
                                    Properties.Settings.Default.Save();

                                    int timeInSeconds = Convert.ToInt32(result);
                                    hour = timeInSeconds;
                                    minute = 00;
                                    second = 00;
                                    timer1.Interval = 1000;
                                    timer1.Start();
                                }
                                else
                                {
                                    DateTime sonGirisTarihi = Properties.Settings.Default.LastLoginDate;
                                    DateTime bugun = DateTime.Today;

                                    if (sonGirisTarihi.Date != bugun)
                                    {
                                        int timeInSeconds = Convert.ToInt32(result);
                                        hour = timeInSeconds;
                                        minute = 00;
                                        second = 00;
                                        timer1.Interval = 1000;
                                        timer1.Start();
                                        Properties.Settings.Default.LastLoginDate = bugun;
                                        Properties.Settings.Default.Save();
                                    }
                                    else
                                    {
                                        hour = Properties.Settings.Default.h;
                                        minute = Properties.Settings.Default.m;
                                        second = Properties.Settings.Default.s;
                                        timer1.Interval = 1000;
                                        timer1.Start();
                                        Properties.Settings.Default.Save();
                                    }
                                }

                            }
                        }
                    }
                }
            }
            if (hour == 0 && minute == 0 && second == 0)
            {
                MessageBox.Show("Süren Bittiği İçin 10 Saniye sonra Bilgisayarın Kapanacak.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Timer timer = new Timer();
                timer.Interval = 10000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0 /f");

            if (sender is Timer timer)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.h = hour;
            Properties.Settings.Default.m = minute;
            Properties.Settings.Default.s = second;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RefleshPanel();
        }
        private void RefleshPanel()
        {
            if (groupRequest.Visible)
            {
                groupRequest.Visible = false;
            }
            else
            {
                groupRequest.Visible = true;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM AccesTable WHERE ReceiverMail = @CMail AND isAllowed = 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CMail", Properties.Settings.Default.ChildMail);

                        connection.Open();

                        int userCount = (int)command.ExecuteScalar();
                        connection.Close();
                        if (userCount > 0)
                        {
                            pnlRequest.Visible = true;
                            string queryParentMail = "SELECT RequesterMail FROM AccesTable WHERE ReceiverMail = @CMail AND isAllowed = 0";
                            using (SqlCommand commandParentMail = new SqlCommand(queryParentMail, connection))
                            {
                                commandParentMail.Parameters.AddWithValue("@CMail", Properties.Settings.Default.ChildMail);
                                connection.Open();

                                using (SqlDataReader reader = commandParentMail.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        RequesterMail = reader.GetString(0);
                                        lblMail.Text = RequesterMail;
                                    }
                                }
                            }
                        }
                        else
                        {
                            pnlRequest.Visible = false;
                        }
                    }
                }
            }
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string checkQuery = "SELECT COUNT(*) FROM PasTable WHERE Childmail = @cmail AND Date = @date";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@cmail", Properties.Settings.Default.ChildMail);
                        checkCommand.Parameters.AddWithValue("@date", DateTime.Today);

                        connection.Open();

                        int existingDataCount = (int)checkCommand.ExecuteScalar();
                        if (existingDataCount == 0)
                        {
                            string query = "INSERT INTO PasTable (Childmail, Date, RemainingTime) VALUES (@cmail, @date, @time)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {

                                command.Parameters.AddWithValue("@cmail", Properties.Settings.Default.ChildMail);
                                command.Parameters.AddWithValue("@date", DateTime.Today);
                                command.Parameters.AddWithValue("@time",label1.Text);
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                        else
                        {
                            string query = "UPDATE PasTable SET Childmail = @cmail, Date=@date, RemainingTime=@time";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {

                                command.Parameters.AddWithValue("@cmail", Properties.Settings.Default.ChildMail);
                                command.Parameters.AddWithValue("@date", DateTime.Today);
                                command.Parameters.AddWithValue("@time", label1.Text);
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                    }             
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            var programTitles = new List<string>();


            foreach (Process process in processes)
            {
                try
                {
                    if (!process.HasExited) 
                    {
                        string title = process.MainWindowTitle;

                        if (!string.IsNullOrEmpty(title))
                        {
                            programTitles.Add(title);
                        }
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    continue;
                }
            }
            string[] programTitlesArray = programTitles.ToArray();
            appNamess = programTitlesArray;
        }

        private void saver_Tick(object sender, EventArgs e)
        {
            string birlesikString = string.Join(", ", appNamess);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // E-posta için bugünün tarihindeki kayıtları al
                string sqlQuery = "SELECT AppName FROM AppWithDate WHERE ChildMail = @ChildMail AND Date = @Date";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ChildMail", Properties.Settings.Default.ChildMail);
                command.Parameters.AddWithValue("@Date", DateTime.Today);

                List<string> existingApps = new List<string>();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    existingApps.Add(reader["AppName"].ToString());
                }
                reader.Close();

                foreach (var app in appNamess)
                {
                    // Eğer yeni eklenen değer daha önce eklenmemişse, ekle
                    if (!existingApps.Contains(app))
                    {
                        sqlQuery = "INSERT INTO AppWithDate (ChildMail, Date, AppName) VALUES (@ChildMail, @Date, @AppName)";
                        command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@AppName", app);
                        command.Parameters.AddWithValue("@Date", DateTime.Today);
                        command.Parameters.AddWithValue("@ChildMail", Properties.Settings.Default.ChildMail);
                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE AccesTable SET isAllowed = 1 WHERE RequesterMail = @RMail; ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RMail", RequesterMail);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        LinkedAccounts();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                if (minute > 0)
                {
                    minute--;
                    second = 59;
                }
                else
                {
                    if (hour > 0)
                    {
                        hour--;
                        minute = 59;
                        second = 59;
                    }
                    else
                    {
                        timer1.Stop();
                        Process.Start("shutdown", "/s /t 0 /f");
                    }
                }
            }
            label1.Text = $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        private void LinkedAccounts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryParentMailID = "SELECT ParentID FROM ParentTable WHERE ParentMail = @PMail";
                    using (SqlCommand commandParentMailID = new SqlCommand(queryParentMailID, connection))
                    {
                        commandParentMailID.Parameters.AddWithValue("@PMail", RequesterMail);

                        using (SqlDataReader reader = commandParentMailID.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ıd = reader.GetInt32(0);
                                ParentID = ıd.ToString();
                            }
                        }
                    }

                    string queryChildMailID = "SELECT ChildID FROM ChildTable WHERE ChildMail = @CMail";
                    using (SqlCommand commandChildMailID = new SqlCommand(queryChildMailID, connection))
                    {
                        commandChildMailID.Parameters.AddWithValue("@CMail", Properties.Settings.Default.ChildMail);

                        using (SqlDataReader reader = commandChildMailID.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ıd = reader.GetInt32(0);
                                ChildID = ıd.ToString();
                            }
                        }
                    }

                    string queryLink = "INSERT INTO LinkedAccounts (ParentID, ChildID) VALUES (@PID, @CID)";
                    using (SqlCommand commandLink = new SqlCommand(queryLink, connection))
                    {
                        commandLink.Parameters.AddWithValue("@PID", ParentID);
                        commandLink.Parameters.AddWithValue("@CID", ChildID);

                        commandLink.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            MessageBox.Show("Bağlantı Onaylanmıştır.");
            RefleshPanel();
        }
    }
}
