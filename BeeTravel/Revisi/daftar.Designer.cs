namespace Revisi
{
    partial class daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(daftar));
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cek = new System.Windows.Forms.Button();
            this.txt_konfirmasipass = new System.Windows.Forms.TextBox();
            this.lblkonfpass = new System.Windows.Forms.Label();
            this.btn_masuk = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(637, 495);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(101, 30);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "KELUAR";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // btn_cek
            // 
            this.btn_cek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cek.Location = new System.Drawing.Point(853, 296);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(39, 29);
            this.btn_cek.TabIndex = 27;
            this.btn_cek.Text = "CEK";
            this.btn_cek.UseVisualStyleBackColor = false;
            this.btn_cek.Click += new System.EventHandler(this.btn_cek_Click);
            // 
            // txt_konfirmasipass
            // 
            this.txt_konfirmasipass.Location = new System.Drawing.Point(521, 418);
            this.txt_konfirmasipass.Multiline = true;
            this.txt_konfirmasipass.Name = "txt_konfirmasipass";
            this.txt_konfirmasipass.PasswordChar = '*';
            this.txt_konfirmasipass.Size = new System.Drawing.Size(326, 25);
            this.txt_konfirmasipass.TabIndex = 26;
            // 
            // lblkonfpass
            // 
            this.lblkonfpass.AutoSize = true;
            this.lblkonfpass.BackColor = System.Drawing.Color.Transparent;
            this.lblkonfpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkonfpass.Location = new System.Drawing.Point(516, 390);
            this.lblkonfpass.Name = "lblkonfpass";
            this.lblkonfpass.Size = new System.Drawing.Size(213, 25);
            this.lblkonfpass.TabIndex = 25;
            this.lblkonfpass.Text = "Konfirmasi Password";
            // 
            // btn_masuk
            // 
            this.btn_masuk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_masuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_masuk.Location = new System.Drawing.Point(559, 449);
            this.btn_masuk.Name = "btn_masuk";
            this.btn_masuk.Size = new System.Drawing.Size(249, 40);
            this.btn_masuk.TabIndex = 24;
            this.btn_masuk.Text = "DAFTAR";
            this.btn_masuk.UseVisualStyleBackColor = false;
            this.btn_masuk.Click += new System.EventHandler(this.btn_masuk_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(521, 363);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(326, 24);
            this.txt_password.TabIndex = 23;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(521, 300);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(326, 23);
            this.txt_username.TabIndex = 22;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(516, 339);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(106, 25);
            this.lblpassword.TabIndex = 21;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(516, 272);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(110, 25);
            this.lblusername.TabIndex = 20;
            this.lblusername.Text = "Username";
            // 
            // daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 723);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.txt_konfirmasipass);
            this.Controls.Add(this.lblkonfpass);
            this.Controls.Add(this.btn_masuk);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Name = "daftar";
            this.Text = "daftar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cek;
        private System.Windows.Forms.TextBox txt_konfirmasipass;
        private System.Windows.Forms.Label lblkonfpass;
        private System.Windows.Forms.Button btn_masuk;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
    }
}