namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnbaslat = new Button();
            tbxtahmin = new TextBox();
            btntahmin = new Button();
            lblKalanHak = new Label();
            lblsonuc = new Label();
            panel1 = new Panel();
            lbl1 = new Label();
            btngizle = new Button();
            lbltutulan = new Label();
            btngöster = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnbaslat
            // 
            btnbaslat.BackColor = Color.FromArgb(128, 255, 128);
            btnbaslat.Font = new Font("Segoe UI", 15F);
            btnbaslat.Location = new Point(104, 64);
            btnbaslat.Name = "btnbaslat";
            btnbaslat.Size = new Size(253, 48);
            btnbaslat.TabIndex = 0;
            btnbaslat.Text = "Başlat / Yeniden Başlat";
            btnbaslat.UseVisualStyleBackColor = false;
            btnbaslat.Click += btnbaslat_Click;
            // 
            // tbxtahmin
            // 
            tbxtahmin.Font = new Font("Segoe UI", 12F);
            tbxtahmin.Location = new Point(129, 168);
            tbxtahmin.Name = "tbxtahmin";
            tbxtahmin.Size = new Size(100, 29);
            tbxtahmin.TabIndex = 1;
            // 
            // btntahmin
            // 
            btntahmin.BackColor = SystemColors.MenuHighlight;
            btntahmin.Font = new Font("Segoe UI", 12F);
            btntahmin.Location = new Point(235, 164);
            btntahmin.Name = "btntahmin";
            btntahmin.Size = new Size(107, 35);
            btntahmin.TabIndex = 2;
            btntahmin.Text = "Tahmin Et";
            btntahmin.UseVisualStyleBackColor = false;
            btntahmin.Click += btntahmin_Click;
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Font = new Font("Segoe UI", 12F);
            lblKalanHak.Location = new Point(172, 126);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(108, 21);
            lblKalanHak.TabIndex = 4;
            lblKalanHak.Text = "Kalan Hak : 10";
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.BackColor = SystemColors.GradientActiveCaption;
            lblsonuc.Font = new Font("Segoe UI", 13F);
            lblsonuc.Location = new Point(45, 15);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(149, 25);
            lblsonuc.TabIndex = 5;
            lblsonuc.Text = "Tahmininizi Girin !";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(btngizle);
            panel1.Controls.Add(lbltutulan);
            panel1.Controls.Add(btngöster);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(lblsonuc);
            panel1.Location = new Point(3, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 370);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(81, 58);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(82, 21);
            lbl1.TabIndex = 13;
            lbl1.Text = "------------";
            // 
            // btngizle
            // 
            btngizle.Location = new Point(138, 295);
            btngizle.Name = "btngizle";
            btngizle.Size = new Size(139, 23);
            btngizle.TabIndex = 12;
            btngizle.Text = "Tutulan Sayıyı Gizle";
            btngizle.UseVisualStyleBackColor = true;
            btngizle.Visible = false;
            btngizle.Click += btngizle_Click;
            // 
            // lbltutulan
            // 
            lbltutulan.AutoSize = true;
            lbltutulan.Location = new Point(189, 328);
            lbltutulan.Name = "lbltutulan";
            lbltutulan.Size = new Size(37, 15);
            lbltutulan.TabIndex = 11;
            lbltutulan.Text = "------";
            lbltutulan.Visible = false;
            // 
            // btngöster
            // 
            btngöster.Location = new Point(138, 295);
            btngöster.Name = "btngöster";
            btngöster.Size = new Size(139, 23);
            btngöster.TabIndex = 10;
            btngöster.Text = "Tutulan Sayıyı Göster";
            btngöster.UseVisualStyleBackColor = true;
            btngöster.Click += btngöster_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(427, 169);
            listBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 37);
            label1.TabIndex = 9;
            label1.Text = "4 HANELİ SAYI TAHMİN OYUNU";
            // 
            // Form1
            // 
            AcceptButton = btntahmin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(474, 621);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblKalanHak);
            Controls.Add(btntahmin);
            Controls.Add(tbxtahmin);
            Controls.Add(btnbaslat);
            Name = "Form1";
            Text = "4 Haneli Sayı Tahmin Oyunu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbaslat;
        private TextBox tbxtahmin;
        private Button btntahmin;
        private Label lblKalanHak;
        private Label lblsonuc;
        private Panel panel1;
        private ListBox listBox1;
        private Button btngöster;
        private Label lbltutulan;
        private Button btngizle;
        private Label lbl1;
        private Label label1;
    }
}
