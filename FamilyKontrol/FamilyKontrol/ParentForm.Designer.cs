
namespace FamilyKontrol
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnConnected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimeAccept = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAccesRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRMail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMail = new System.Windows.Forms.ComboBox();
            this.btnApp = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHello.Location = new System.Drawing.Point(12, 18);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(179, 20);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Merhaba, Erdem Kurt";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(544, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 54);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Çocuk Hesabı Ekle";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(669, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(119, 54);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Geçmişi Kontrol Et";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnConnected
            // 
            this.btnConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnected.Location = new System.Drawing.Point(419, 0);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(119, 54);
            this.btnConnected.TabIndex = 7;
            this.btnConnected.Text = "Bağlı Hesaplar";
            this.btnConnected.UseVisualStyleBackColor = false;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lblEposta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTimeAccept);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnReflesh);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 176);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlı Hesaplar";
            this.groupBox1.Visible = false;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoEllipsis = true;
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(211, 42);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(10, 13);
            this.lblEposta.TabIndex = 15;
            this.lblEposta.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saat Kısıtlaması";
            // 
            // btnTimeAccept
            // 
            this.btnTimeAccept.Location = new System.Drawing.Point(183, 127);
            this.btnTimeAccept.Name = "btnTimeAccept";
            this.btnTimeAccept.Size = new System.Drawing.Size(77, 37);
            this.btnTimeAccept.TabIndex = 13;
            this.btnTimeAccept.Text = "Kabul Et";
            this.btnTimeAccept.UseVisualStyleBackColor = true;
            this.btnTimeAccept.Click += new System.EventHandler(this.btnTimeAccept_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(162, 78);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(121, 20);
            this.txtTime.TabIndex = 7;
            this.txtTime.Text = "1";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(9, 127);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 37);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btnReflesh
            // 
            this.btnReflesh.Location = new System.Drawing.Point(9, 78);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(95, 37);
            this.btnReflesh.TabIndex = 7;
            this.btnReflesh.Text = "Yenile";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnAccesRequest);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRMail);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çocuk Hesabı Ekle";
            this.groupBox2.Visible = false;
            // 
            // btnAccesRequest
            // 
            this.btnAccesRequest.Location = new System.Drawing.Point(92, 111);
            this.btnAccesRequest.Name = "btnAccesRequest";
            this.btnAccesRequest.Size = new System.Drawing.Size(95, 37);
            this.btnAccesRequest.TabIndex = 6;
            this.btnAccesRequest.Text = "Bağlanma İsteği Gönder";
            this.btnAccesRequest.UseVisualStyleBackColor = true;
            this.btnAccesRequest.Click += new System.EventHandler(this.btnAccesRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bağlanmak İstediğiniz Çocuk Hesabının Epostasını Griniz*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eposta";
            // 
            // txtRMail
            // 
            this.txtRMail.Location = new System.Drawing.Point(122, 39);
            this.txtRMail.Name = "txtRMail";
            this.txtRMail.Size = new System.Drawing.Size(121, 20);
            this.txtRMail.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnFilter);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.datePicker);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbMail);
            this.groupBox3.Controls.Add(this.btnApp);
            this.groupBox3.Controls.Add(this.btnTime);
            this.groupBox3.Controls.Add(this.dataView);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(338, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 332);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş";
            this.groupBox3.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(315, 285);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(88, 25);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "tarih";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(139, 290);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(145, 20);
            this.datePicker.TabIndex = 13;
            this.datePicker.Value = new System.DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // cmbMail
            // 
            this.cmbMail.FormattingEnabled = true;
            this.cmbMail.Location = new System.Drawing.Point(6, 289);
            this.cmbMail.Name = "cmbMail";
            this.cmbMail.Size = new System.Drawing.Size(95, 21);
            this.cmbMail.TabIndex = 12;
            // 
            // btnApp
            // 
            this.btnApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp.Location = new System.Drawing.Point(112, 34);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(105, 25);
            this.btnApp.TabIndex = 2;
            this.btnApp.Text = "Uygulama Geçmişi";
            this.btnApp.UseVisualStyleBackColor = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Location = new System.Drawing.Point(6, 34);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(88, 25);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "Süre Geçmişi";
            this.btnTime.UseVisualStyleBackColor = false;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // dataView
            // 
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(0, 66);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(450, 196);
            this.dataView.TabIndex = 0;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.Load += new System.EventHandler(this.ParentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAccesRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRMail;
        private System.Windows.Forms.Button btnReflesh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimeAccept;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMail;
    }
}