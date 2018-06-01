namespace Revisi
{
    partial class Kereta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereta));
            this.pictureBox1_home = new System.Windows.Forms.PictureBox();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.btn_cek = new System.Windows.Forms.Button();
            this.cmb_ktujuan = new System.Windows.Forms.ComboBox();
            this.cmb_kasal = new System.Windows.Forms.ComboBox();
            this.cmb_jum_penum = new System.Windows.Forms.ComboBox();
            this.tarif = new System.Windows.Forms.Label();
            this.cmb_penumpang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.cmb_kelaskereta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_home
            // 
            this.pictureBox1_home.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_home.Image")));
            this.pictureBox1_home.Location = new System.Drawing.Point(1031, 575);
            this.pictureBox1_home.Name = "pictureBox1_home";
            this.pictureBox1_home.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_home.TabIndex = 64;
            this.pictureBox1_home.TabStop = false;
            this.pictureBox1_home.Click += new System.EventHandler(this.pictureBox1_home_Click);
            // 
            // btn_bayar
            // 
            this.btn_bayar.BackColor = System.Drawing.Color.Black;
            this.btn_bayar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_bayar.Location = new System.Drawing.Point(1006, 646);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(131, 29);
            this.btn_bayar.TabIndex = 63;
            this.btn_bayar.Text = "BAYAR";
            this.btn_bayar.UseVisualStyleBackColor = false;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // btn_cek
            // 
            this.btn_cek.BackColor = System.Drawing.Color.Black;
            this.btn_cek.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cek.Location = new System.Drawing.Point(785, 625);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(41, 29);
            this.btn_cek.TabIndex = 98;
            this.btn_cek.Text = "Cek";
            this.btn_cek.UseVisualStyleBackColor = false;
            this.btn_cek.Click += new System.EventHandler(this.btn_cek_Click);
            // 
            // cmb_ktujuan
            // 
            this.cmb_ktujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ktujuan.FormattingEnabled = true;
            this.cmb_ktujuan.Items.AddRange(new object[] {
            "palu",
            "kendari",
            "solo",
            "merauke",
            "pomalaa"});
            this.cmb_ktujuan.Location = new System.Drawing.Point(503, 498);
            this.cmb_ktujuan.Name = "cmb_ktujuan";
            this.cmb_ktujuan.Size = new System.Drawing.Size(185, 21);
            this.cmb_ktujuan.TabIndex = 97;
            // 
            // cmb_kasal
            // 
            this.cmb_kasal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kasal.FormattingEnabled = true;
            this.cmb_kasal.Items.AddRange(new object[] {
            "makassar",
            "jakarta",
            "semarang",
            "yogyakarta",
            "medan"});
            this.cmb_kasal.Location = new System.Drawing.Point(212, 498);
            this.cmb_kasal.Name = "cmb_kasal";
            this.cmb_kasal.Size = new System.Drawing.Size(185, 21);
            this.cmb_kasal.TabIndex = 96;
            // 
            // cmb_jum_penum
            // 
            this.cmb_jum_penum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jum_penum.FormattingEnabled = true;
            this.cmb_jum_penum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_jum_penum.Location = new System.Drawing.Point(211, 593);
            this.cmb_jum_penum.Name = "cmb_jum_penum";
            this.cmb_jum_penum.Size = new System.Drawing.Size(185, 21);
            this.cmb_jum_penum.TabIndex = 95;
            // 
            // tarif
            // 
            this.tarif.AutoSize = true;
            this.tarif.BackColor = System.Drawing.Color.Transparent;
            this.tarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarif.Location = new System.Drawing.Point(832, 628);
            this.tarif.Name = "tarif";
            this.tarif.Size = new System.Drawing.Size(0, 20);
            this.tarif.TabIndex = 94;
            // 
            // cmb_penumpang
            // 
            this.cmb_penumpang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_penumpang.FormattingEnabled = true;
            this.cmb_penumpang.Items.AddRange(new object[] {
            "Lansia",
            "Dewasa",
            "Anak-Anak"});
            this.cmb_penumpang.Location = new System.Drawing.Point(785, 592);
            this.cmb_penumpang.Name = "cmb_penumpang";
            this.cmb_penumpang.Size = new System.Drawing.Size(185, 21);
            this.cmb_penumpang.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(782, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Penumpang";
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Location = new System.Drawing.Point(785, 495);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(181, 20);
            this.dtp_tanggal.TabIndex = 91;
            // 
            // cmb_kelaskereta
            // 
            this.cmb_kelaskereta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kelaskereta.FormattingEnabled = true;
            this.cmb_kelaskereta.Items.AddRange(new object[] {
            "Ekonomi",
            "Bisnis",
            "Eksekutif"});
            this.cmb_kelaskereta.Location = new System.Drawing.Point(503, 593);
            this.cmb_kelaskereta.Name = "cmb_kelaskereta";
            this.cmb_kelaskereta.Size = new System.Drawing.Size(185, 21);
            this.cmb_kelaskereta.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Jumlah Penumpang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Kelas Kereta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tanggal Berangkat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Kota Tujuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Kota Asal";
            // 
            // Kereta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 723);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.cmb_ktujuan);
            this.Controls.Add(this.cmb_kasal);
            this.Controls.Add(this.cmb_jum_penum);
            this.Controls.Add(this.tarif);
            this.Controls.Add(this.cmb_penumpang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.cmb_kelaskereta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1_home);
            this.Controls.Add(this.btn_bayar);
            this.Name = "Kereta";
            this.Text = "Kereta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_home;
        private System.Windows.Forms.Button btn_bayar;
        private System.Windows.Forms.Button btn_cek;
        private System.Windows.Forms.ComboBox cmb_ktujuan;
        private System.Windows.Forms.ComboBox cmb_kasal;
        private System.Windows.Forms.ComboBox cmb_jum_penum;
        private System.Windows.Forms.Label tarif;
        private System.Windows.Forms.ComboBox cmb_penumpang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.ComboBox cmb_kelaskereta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}