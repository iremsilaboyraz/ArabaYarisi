using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private bool isMovingLeft = false;
        private bool isMovingRight = false;
        private Random rnd = new Random(); // Random nesnesini burada tanımladık
        private int score = 0; // Skor değişkeni

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); // KeyDown olayını ekleyin
            this.KeyUp += new KeyEventHandler(Form1_KeyUp); // KeyUp olayını ekleyin
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Space tuşuna basıldığında
            {
                if (!oyunTimer.Enabled) // Oyun başlamadıysa
                {
                    oyunTimer.Start(); // Oyun başlat
                }
            }
            if (e.KeyCode == Keys.Left) // Sol ok tuşuna basıldığında
            {
                isMovingLeft = true;
            }
            if (e.KeyCode == Keys.Right) // Sağ ok tuşuna basıldığında
            {
                isMovingRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // Sol ok tuşu bırakıldığında
            {
                isMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right) // Sağ ok tuşu bırakıldığında
            {
                isMovingRight = false;
            }
        }

        private void oyunTimer_Tick(object sender, EventArgs e)
        {
            // Arabaların hareket etmesi
            Araba1.Top += 5;
            Araba2.Top += 5;
            Araba3.Top += 5;

            // Arabaların ekran dışına çıkarsa üst kısma geri dönmesi
            if (Araba1.Top > this.ClientSize.Height)
            {
                Araba1.Top = -Araba1.Height;
                Araba1.Left = rnd.Next(0, this.ClientSize.Width - Araba1.Width); // Random yeni konum
                score++; // Skoru arttır
            }

            if (Araba2.Top > this.ClientSize.Height)
            {
                Araba2.Top = -Araba2.Height;
                Araba2.Left = rnd.Next(0, this.ClientSize.Width - Araba2.Width); // Random yeni konum
                score++; // Skoru arttır
            }

            if (Araba3.Top > this.ClientSize.Height)
            {
                Araba3.Top = -Araba3.Height;
                Araba3.Left = rnd.Next(0, this.ClientSize.Width - Araba3.Width); // Random yeni konum
                score++; // Skoru arttır
            }

            // Kullanıcı arabası hareketi (sağ ve sol ok tuşları)
            if (isMovingLeft && KullaniciArabasi.Left > 0)
            {
                KullaniciArabasi.Left -= 10;
            }
            if (isMovingRight && KullaniciArabasi.Left < this.ClientSize.Width - KullaniciArabasi.Width)
            {
                KullaniciArabasi.Left += 10;
            }

            // Çarpışma kontrolü
            if (KullaniciArabasi.Bounds.IntersectsWith(Araba1.Bounds) ||
                KullaniciArabasi.Bounds.IntersectsWith(Araba2.Bounds) ||
                KullaniciArabasi.Bounds.IntersectsWith(Araba3.Bounds))
            {
                oyunTimer.Stop(); // Oyun durduruluyor
                MessageBox.Show("Çarpıştınız! Oyunu yeniden başlatın.", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestartGame(); // Oyunu sıfırlıyoruz
            }

            lblSkor.Text = $"Skor: {score}"; // Skoru güncelle
        }

        // Oyun sıfırlama metodu
        private void RestartGame()
        {
            // Arabaları başlatma konumlarına sıfırlama
            Araba1.Top = -Araba1.Height;
            Araba1.Left = rnd.Next(0, this.ClientSize.Width - Araba1.Width);

            Araba2.Top = -Araba2.Height;
            Araba2.Left = rnd.Next(0, this.ClientSize.Width - Araba2.Width);

            Araba3.Top = -Araba3.Height;
            Araba3.Left = rnd.Next(0, this.ClientSize.Width - Araba3.Width);

            KullaniciArabasi.Top = this.ClientSize.Height - KullaniciArabasi.Height - 10;
            KullaniciArabasi.Left = this.ClientSize.Width / 2 - KullaniciArabasi.Width / 2;

            score = 0; // Skoru sıfırlama
            lblSkor.Text = "Skor: 0"; // Skoru sıfırlama
            oyunTimer.Start(); // Oyun yeniden başlasın
        }
    }
}
