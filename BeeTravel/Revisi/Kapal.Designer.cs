namespace Revisi
{
    partial class Kapal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kapal));
            this.pictureBox1_home = new System.Windows.Forms.PictureBox();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.btn_cek = new System.Windows.Forms.Button();
            this.cmb_ktujuan = new System.Windows.Forms.ComboBox();
            this.cmb_kasal = new System.Windows.Forms.ComboBox();
            this.cmb_jum_penum = new System.Windows.Forms.ComboBox();
            this.tarif = new System.Windows.Forms.Label();
            this.cmb_penumpang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_kelaskapal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_tanggal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_home
            // 
            this.pictureBox1_home.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_home.Image")));
            this.pictureBox1_home.Location = new System.Drawing.Point(1035, 559);
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
            this.btn_bayar.Location = new System.Drawing.Point(1010, 630);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Penumpang";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(785, 495);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // cmb_kelaskapal
            // 
            this.cmb_kelaskapal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kelaskapal.FormattingEnabled = true;
            this.cmb_kelaskapal.Items.AddRange(new object[] {
            "Ekonomi",
            "Bisnis",
            "Eksekutif"});
            this.cmb_kelaskapal.Location = new System.Drawing.Point(503, 593);
            this.cmb_kelaskapal.Name = "cmb_kelaskapal";
            this.cmb_kelaskapal.Size = new System.Drawing.Size(185, 21);
            this.cmb_kelaskapal.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Jumlah Penumpang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Kelas Kapal";
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.AutoSize = true;
            this.dtp_tanggal.BackColor = System.Drawing.Color.Transparent;
            this.dtp_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tanggal.Location = new System.Drawing.Point(782, 459);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(144, 20);
            this.dtp_tanggal.TabIndex = 87;
            this.dtp_tanggal.Text = "Tanggal Berangkat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(500, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Kota Tujuan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 85;
            this.label13.Text = "Kota Asal";
            // 
            // Kapal
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_kelaskapal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1_home);
            this.Controls.Add(this.btn_bayar);
            this.Name = "Kapal";
            this.Text = "Kapal";
            this.Load += new System.EventHandler(this.Kapal_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_kelaskapal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dtp_tanggal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

    }
}