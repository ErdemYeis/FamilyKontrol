using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace FamilyKontrol
{
    public partial class LoginAndRegister : Form
    {
        string connectionString = @"Data Source=DESKTOP-HOOKELP\SQLEXPRESS;Initial Catalog=FamilyControl;Integrated Security=True";
        string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public LoginAndRegister()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = txtLoginE.Text;
            string pass = txtLoginPass.Text;

            string hashedPassword = Sha256.ComputeSha256Hash(pass);

            if (mail != "" || pass != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM ParentTable WHERE ParentMail = @PMail AND ParentPass = @PPass";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PMail", mail);
                        command.Parameters.AddWithValue("@PPass", hashedPassword);

                        connection.Open();

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Giriş başarılı!");
                            Properties.Settings.Default.ParentMail = mail;
                            Properties.Settings.Default.Save();
                            ParentForm pform = new ParentForm();
                            pform.Show();
                            this.Hide();

                        }
                        else
                        {
                            string Cquery = "SELECT COUNT(*) FROM ChildTable WHERE ChildMail = @CMail AND ChildPass = @CPass";
                            using (SqlCommand Ccommand = new SqlCommand(Cquery, connection))
                            {
                                Ccommand.Parameters.AddWithValue("@CMail", mail);
                                Ccommand.Parameters.AddWithValue("@CPass", hashedPassword);


                                int CuserCount = (int)Ccommand.ExecuteScalar();

                                if (CuserCount > 0)
                                {
                                    MessageBox.Show("Giriş başarılı!");
                                    Properties.Settings.Default.ChildMail = mail;
                                    Properties.Settings.Default.ChildPass = pass;
                                    Properties.Settings.Default.Save();

                                    ChildForm cform = new ChildForm();
                                    cform.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("EPosta veya şifre yanlış!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string mail = txtRegE.Text;
            string name = txtRegName.Text;
            string pass = txtRegPass.Text;

            bool isEmail = Regex.IsMatch(mail, emailPattern);

            if (isEmail)
            {
                if (pass.Length < 6)
                {
                    MessageBox.Show("Şifreniz 6 Karakterden Büyük Olmalıdır", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (name == null)
                    {
                        MessageBox.Show("Ad Ve Soyad Boş Geçilemez", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (rdrParent.Checked)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                string query = "INSERT INTO ParentTable (ParentName, ParentMail, ParentPass) VALUES (@PName, @PMail, @PPass)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    string hashedPassword = Sha256.ComputeSha256Hash(pass);

                                    command.Parameters.AddWithValue("@PName", name);
                                    command.Parameters.AddWithValue("@PMail", mail);
                                    command.Parameters.AddWithValue("@PPass", hashedPassword);

                                    connection.Open();
                                    int result = command.ExecuteNonQuery();

                                    if (result > 0)
                                    {
                                        MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kayıt Oluşturulurken Bir Hata Meydana Geldi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else if (rdrChild.Checked)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                string query = "INSERT INTO ChildTable (ChildName, ChildMail, ChildPass) VALUES (@CName, @CMail, @CPass)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    string hashedPassword = Sha256.ComputeSha256Hash(pass);

                                    command.Parameters.AddWithValue("@CName", name);
                                    command.Parameters.AddWithValue("@CMail", mail);
                                    command.Parameters.AddWithValue("@CPass", hashedPassword);

                                    connection.Open();
                                    int result = command.ExecuteNonQuery();

                                    if (result > 0)
                                    {
                                        MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kayıt Oluşturulurken Bir Hata Meydana Geldi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Girilen email adresi geçerli değil. Lütfen doğru bir email adresi girin.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginAndRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
