using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NESNE.ödev__2
{
    public partial class çekiliş : Form
    {
        public çekiliş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HashSet<int> kullaniciSayilari = new HashSet<int>
                {
                    int.Parse(txtSayi1.Text),
                    int.Parse(txtSayi2.Text),
                    int.Parse(txtSayi3.Text),

                };
                if (kullaniciSayilari.Any(s => s < 9 || s > 39))
                {
                    TextBox.Show("Lütfen 9 ile 39 arasında 3 farklı sayı girin");
                    return;
                }
                int buyukOdulSayisi = 0;
                Random rnd = new
                    Random();
                for (int i = 0; i < 1000; i++)
                {
                    HashSet<int>
                        cekilisSayilari = new
                        HashSet<int>();
                    while (cekilisSayilari.Count < 3)
                    {
                        cekilisSayilari.Add(rnd.Next(9, 40));
                    }
                    if (cekilisSayilari.SetEquals(kullaniciSayilari))
                    {
                        buyukOdulSayisi++;
                    }

                }
                lb1Sonuc.Text = $"Büyük Ödül{buyukOdulSayisi}kez kazanıldı!";
                catch
                {
                TextBox.Show("Lütfen geçerli sayilar girin.");

            }   }
                    
                
        }
    }
}
