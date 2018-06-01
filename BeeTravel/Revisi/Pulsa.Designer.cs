namespace Revisi
{
    partial class Pulsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pulsa));
            this.button1 = new System.Windows.Forms.Button();
            this.tarif_data = new System.Windows.Forms.Label();
            this.cmb_pulsa = new System.Windows.Forms.ComboBox();
            this.txt_no_pulsa = new System.Windows.Forms.TextBox();
            this.lbl_pulsa = new System.Windows.Forms.Label();
            this.lbl_no_pulsadata = new System.Windows.Forms.Label();
            this.lbl_no_pulsa = new System.Windows.Forms.Label();
            this.cmb_pulsadata = new System.Windows.Forms.ComboBox();
            this.lbl_paketdata = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tarif_pulsa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_no_data = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(1012, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 46;
            this.button1.Text = "BAYAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarif_data
            // 
            this.tarif_data.AutoSize = true;
            this.tarif_data.BackColor = System.Drawing.Color.Transparent;
            this.tarif_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tarif_data.Location = new System.Drawing.Point(654, 645);
            this.tarif_data.Name = "tarif_data";
            this.tarif_data.Size = new System.Drawing.Size(40, 20);
            this.tarif_data.TabIndex = 44;
            this.tarif_data.Text = "Tarif";
            // 
            // cmb_pulsa
            // 
            this.cmb_pulsa.FormattingEnabled = true;
            this.cmb_pulsa.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cmb_pulsa.Location = new System.Drawing.Point(365, 621);
            this.cmb_pulsa.Name = "cmb_pulsa";
            this.cmb_pulsa.Size = new System.Drawing.Size(185, 21);
            this.cmb_pulsa.TabIndex = 36;
            this.cmb_pulsa.SelectedIndexChanged += new System.EventHandler(this.cmb_pulsa_SelectedIndexChanged);
            // 
            // txt_no_pulsa
            // 
            this.txt_no_pulsa.Location = new System.Drawing.Point(365, 541);
            this.txt_no_pulsa.Multiline = true;
            this.txt_no_pulsa.Name = "txt_no_pulsa";
            this.txt_no_pulsa.Size = new System.Drawing.Size(185, 29);
            this.txt_no_pulsa.TabIndex = 33;
            this.txt_no_pulsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_pulsa_KeyPress);
            // 
            // lbl_pulsa
            // 
            this.lbl_pulsa.AutoSize = true;
            this.lbl_pulsa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pulsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_pulsa.Location = new System.Drawing.Point(362, 592);
            this.lbl_pulsa.Name = "lbl_pulsa";
            this.lbl_pulsa.Size = new System.Drawing.Size(48, 20);
            this.lbl_pulsa.TabIndex = 31;
            this.lbl_pulsa.Text = "Pulsa";
            // 
            // lbl_no_pulsadata
            // 
            this.lbl_no_pulsadata.AutoSize = true;
            this.lbl_no_pulsadata.BackColor = System.Drawing.Color.Transparent;
            this.lbl_no_pulsadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_no_pulsadata.Location = new System.Drawing.Point(654, 514);
            this.lbl_no_pulsadata.Name = "lbl_no_pulsadata";
            this.lbl_no_pulsadata.Size = new System.Drawing.Size(54, 20);
            this.lbl_no_pulsadata.TabIndex = 29;
            this.lbl_no_pulsadata.Text = "No Hp";
            // 
            // lbl_no_pulsa
            // 
            this.lbl_no_pulsa.AutoSize = true;
            this.lbl_no_pulsa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_no_pulsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_no_pulsa.Location = new System.Drawing.Point(362, 514);
            this.lbl_no_pulsa.Name = "lbl_no_pulsa";
            this.lbl_no_pulsa.Size = new System.Drawing.Size(54, 20);
            this.lbl_no_pulsa.TabIndex = 28;
            this.lbl_no_pulsa.Text = "No Hp";
            // 
            // cmb_pulsadata
            // 
            this.cmb_pulsadata.FormattingEnabled = true;
            this.cmb_pulsadata.Items.AddRange(new object[] {
            "10 GB",
            "15 GB",
            "20 GB",
            "35 GB",
            "50 GB"});
            this.cmb_pulsadata.Location = new System.Drawing.Point(657, 621);
            this.cmb_pulsadata.Name = "cmb_pulsadata";
            this.cmb_pulsadata.Size = new System.Drawing.Size(185, 21);
            this.cmb_pulsadata.TabIndex = 49;
            this.cmb_pulsadata.SelectedIndexChanged += new System.EventHandler(this.cmb_pulsadata_SelectedIndexChanged);
            // 
            // lbl_paketdata
            // 
            this.lbl_paketdata.AutoSize = true;
            this.lbl_paketdata.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paketdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_paketdata.Location = new System.Drawing.Point(654, 592);
            this.lbl_paketdata.Name = "lbl_paketdata";
            this.lbl_paketdata.Size = new System.Drawing.Size(89, 20);
            this.lbl_paketdata.TabIndex = 48;
            this.lbl_paketdata.Text = "Paket Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1037, 541);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(362, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Silahkan Pilih Pulsa  atau Pulsa Data";
            // 
            // tarif_pulsa
            // 
            this.tarif_pulsa.AutoSize = true;
            this.tarif_pulsa.BackColor = System.Drawing.Color.Transparent;
            this.tarif_pulsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tarif_pulsa.Location = new System.Drawing.Point(362, 645);
            this.tarif_pulsa.Name = "tarif_pulsa";
            this.tarif_pulsa.Size = new System.Drawing.Size(40, 20);
            this.tarif_pulsa.TabIndex = 54;
            this.tarif_pulsa.Text = "Tarif";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pulsa",
            "Pulsa Data"});
            this.comboBox1.Location = new System.Drawing.Point(365, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_no_data
            // 
            this.txt_no_data.Location = new System.Drawing.Point(658, 541);
            this.txt_no_data.Multiline = true;
            this.txt_no_data.Name = "txt_no_data";
            this.txt_no_data.Size = new System.Drawing.Size(185, 29);
            this.txt_no_data.TabIndex = 56;
            this.txt_no_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_data_KeyPress);
            // 
            // Pulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 723);
            this.Controls.Add(this.txt_no_data);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tarif_pulsa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_pulsadata);
            this.Controls.Add(this.lbl_paketdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarif_data);
            this.Controls.Add(this.cmb_pulsa);
            this.Controls.Add(this.txt_no_pulsa);
            this.Controls.Add(this.lbl_pulsa);
            this.Controls.Add(this.lbl_no_pulsadata);
            this.Controls.Add(this.lbl_no_pulsa);
            this.Name = "Pulsa";
            this.Text = "Pulsa";
            this.Load += new System.EventHandler(this.Pulsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tarif_data;
        private System.Windows.Forms.ComboBox cmb_pulsa;
        private System.Windows.Forms.TextBox txt_no_pulsa;
        private System.Windows.Forms.Label lbl_pulsa;
        private System.Windows.Forms.Label lbl_no_pulsadata;
        private System.Windows.Forms.Label lbl_no_pulsa;
        private System.Windows.Forms.ComboBox cmb_pulsadata;
        private System.Windows.Forms.Label lbl_paketdata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tarif_pulsa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_no_data;
    }
}