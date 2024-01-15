
namespace FamilyKontrol
{
    partial class LoginAndRegister
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdrChild = new System.Windows.Forms.RadioButton();
            this.rdrParent = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLoginPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLoginE);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 264);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(91, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(103, 138);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '*';
            this.txtLoginPass.Size = new System.Drawing.Size(121, 20);
            this.txtLoginPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eposta ";
            // 
            // txtLoginE
            // 
            this.txtLoginE.Location = new System.Drawing.Point(103, 78);
            this.txtLoginE.Name = "txtLoginE";
            this.txtLoginE.Size = new System.Drawing.Size(121, 20);
            this.txtLoginE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giris Yap";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.rdrChild);
            this.panel2.Controls.Add(this.rdrParent);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtRegPass);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRegE);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRegName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel2.Location = new System.Drawing.Point(305, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 292);
            this.panel2.TabIndex = 6;
            // 
            // rdrChild
            // 
            this.rdrChild.AutoSize = true;
            this.rdrChild.Location = new System.Drawing.Point(210, 197);
            this.rdrChild.Name = "rdrChild";
            this.rdrChild.Size = new System.Drawing.Size(55, 18);
            this.rdrChild.TabIndex = 10;
            this.rdrChild.TabStop = true;
            this.rdrChild.Text = "Çocuk";
            this.rdrChild.UseVisualStyleBackColor = true;
            // 
            // rdrParent
            // 
            this.rdrParent.AutoSize = true;
            this.rdrParent.Location = new System.Drawing.Point(137, 197);
            this.rdrParent.Name = "rdrParent";
            this.rdrParent.Size = new System.Drawing.Size(67, 18);
            this.rdrParent.TabIndex = 9;
            this.rdrParent.TabStop = true;
            this.rdrParent.Text = "Ebeveyn";
            this.rdrParent.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kullanıcı Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şifre";
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(103, 155);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.PasswordChar = '*';
            this.txtRegPass.Size = new System.Drawing.Size(121, 20);
            this.txtRegPass.TabIndex = 6;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReg.Location = new System.Drawing.Point(89, 257);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Kayıt Ol";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Eposta";
            // 
            // txtRegE
            // 
            this.txtRegE.Location = new System.Drawing.Point(103, 117);
            this.txtRegE.Name = "txtRegE";
            this.txtRegE.Size = new System.Drawing.Size(121, 20);
            this.txtRegE.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad Soyad";
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(103, 78);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(121, 20);
            this.txtRegName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(70, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kayıt Ol";
            // 
            // LoginAndRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(593, 322);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAndRegister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginAndRegister_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdrChild;
        private System.Windows.Forms.RadioButton rdrParent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label label6;
    }
}

