
namespace FamilyKontrol
{
    partial class ChildForm
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
            this.components = new System.ComponentModel.Container();
            this.lblHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.groupRequest = new System.Windows.Forms.GroupBox();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.btnDenied = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saver = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupRequest.SuspendLayout();
            this.pnlRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHello.Location = new System.Drawing.Point(12, 18);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(179, 20);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Merhaba, Erdem Kurt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Location = new System.Drawing.Point(349, 0);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(119, 54);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "İstekler";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // groupRequest
            // 
            this.groupRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupRequest.Controls.Add(this.pnlRequest);
            this.groupRequest.ForeColor = System.Drawing.Color.Black;
            this.groupRequest.Location = new System.Drawing.Point(230, 60);
            this.groupRequest.Name = "groupRequest";
            this.groupRequest.Size = new System.Drawing.Size(238, 135);
            this.groupRequest.TabIndex = 11;
            this.groupRequest.TabStop = false;
            this.groupRequest.Text = "İstekler";
            this.groupRequest.Visible = false;
            // 
            // pnlRequest
            // 
            this.pnlRequest.Controls.Add(this.btnDenied);
            this.pnlRequest.Controls.Add(this.btnAllow);
            this.pnlRequest.Controls.Add(this.lblMail);
            this.pnlRequest.Location = new System.Drawing.Point(6, 19);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(226, 109);
            this.pnlRequest.TabIndex = 0;
            // 
            // btnDenied
            // 
            this.btnDenied.Location = new System.Drawing.Point(137, 46);
            this.btnDenied.Name = "btnDenied";
            this.btnDenied.Size = new System.Drawing.Size(77, 41);
            this.btnDenied.TabIndex = 2;
            this.btnDenied.Text = "Reddet";
            this.btnDenied.UseVisualStyleBackColor = true;
            // 
            // btnAllow
            // 
            this.btnAllow.Location = new System.Drawing.Point(3, 46);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(77, 41);
            this.btnAllow.TabIndex = 1;
            this.btnAllow.Text = "Onayla";
            this.btnAllow.UseVisualStyleBackColor = true;
            this.btnAllow.Click += new System.EventHandler(this.btnAllow_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(22, 15);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(12, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // saver
            // 
            this.saver.Tick += new System.EventHandler(this.saver_Tick);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(483, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupRequest);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChildForm_FormClosed);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupRequest.ResumeLayout(false);
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox groupRequest;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Button btnDenied;
        private System.Windows.Forms.Button btnAllow;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer saver;
    }
}