using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string rastgeleSayi;        // Üretilen sayı
        int kalanHak;



        private void btnbaslat_Click(object sender, EventArgs e)
        {
            tbxtahmin.Enabled = true;
            btntahmin.Enabled = true;

            Random rnd = new Random();
            int number;

            while (true)
            {
                number = rnd.Next(1000, 10000); // 4 basamaklı sayı üret
                string numStr = number.ToString();

                // Rakamların birbirinden farklı olup olmadığını kontrol et
                if (numStr.Distinct().Count() == 4)
                    break;
            }

            // Label'a yazdır
            lbltutulan.Text = "Rastgele sayı: " + number.ToString();

            //globale ata
            
            kalanHak = 10;
            lblKalanHak.Text="Kalan Hak : "+kalanHak.ToString();
            rastgeleSayi = number.ToString();

            tbxtahmin.Clear();
            lblsonuc.Text = "Tahminizi Girin !";
            listBox1.Items.Clear();
            lbl1.Text = "";

            panel1.Visible = true;

        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            lbltutulan.Visible = true;
            btngöster.Visible = false;
            btngizle.Visible = true;
        }

        private void btngizle_Click(object sender, EventArgs e)
        {
            lbltutulan.Visible = false;
            btngöster.Visible = true;
            btngizle.Visible = false;
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            
            string input = tbxtahmin.Text.Trim();

            tbxtahmin.Focus();

            // Boş mu kontrolü
            if (string.IsNullOrEmpty(input))
            {
                lblsonuc.Text = "Lütfen bir sayı girin.";
                return;
            }

            // Tüm karakterler rakam mı kontrolü
            if (!input.All(char.IsDigit))
            {
                lblsonuc.Text = "Sadece rakam (0-9) giriniz.";
                return;
            }

            // Başta 0 olmaması kontrolü
            if (input.Length > 1 && input[0] == '0')
            {
                lblsonuc.Text = "Başta 0 olamaz (örnek: 0123 geçersiz).";
                return;
            }

            // Basamak sayısı kontrolü (tam 4 olmalı)
            if (input.Length != 4)
            {
                lblsonuc.Text = $"Girdiğiniz sayı {input.Length} basamaklı, 4 basamaklı olmalı!";
                return;
            }

            // Rakamların birbirinden farklı olup olmadığını kontrol et
            if (input.Distinct().Count() != 4)
            {
                lblsonuc.Text = "Rakamlar birbirinden farklı değil!";
                return;
            }

            // Tüm şartlar sağlandıysa (güvenli şekilde int'e çeviriyoruz)

            lblsonuc.Text = $"{input} → 4 basamaklı ve rakamları birbirinden farklı.";

            string tahmin = input.ToString();


            // Doğru/Yanlış Rakam Analizi
            int dogruYerDogruRakam = 0;
            int dogruRakamYanlisYer = 0;

            for (int i = 0; i < 4; i++)
            {
                if (tahmin.ToString()[i] == rastgeleSayi[i])
                    dogruYerDogruRakam++;
                else if (rastgeleSayi.Contains(tahmin.ToString()[i]))
                    dogruRakamYanlisYer++;
            }

            //Kalan hak azalt
            kalanHak--;
            lblKalanHak.Text = "Kalan Hak: " + kalanHak;

            //lbl1’e sonucu yaz
            lbl1.Text = $"{dogruYerDogruRakam} rakamın yeri doğru, {dogruRakamYanlisYer} rakam doğru yeri yanlış.";

            //ListBox’a tahmini ve sonucu ekle
            listBox1.Items.Add($"Tahmin: {tahmin} ➜ {dogruYerDogruRakam} rakamın yeri doğru, {dogruRakamYanlisYer} rakam doğru yeri yanlış.");

            //Doğru tahmin kontrolü
            if (dogruYerDogruRakam == 4)
            {
                lbl1.Text = $"{rastgeleSayi} sayısını doğru tahmin ettiniz!";
                lblsonuc.Text="Tebrikler";
                btntahmin.Enabled = false;
                return;
            }

            //Hak bitti mi?
            if (kalanHak == 0)
            {
                lblsonuc.Text = $"Hakkınız kalmadı! Doğru sayı: {rastgeleSayi}";
                btntahmin.Enabled = false;
            }
            tbxtahmin.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxtahmin.Enabled = false;
            btntahmin.Enabled=false;
        }
    }
}
