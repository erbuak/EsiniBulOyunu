using EsiniBulOyunu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulOyunu
{
    public partial class FrmOyunAlani : Form
    {
        PictureBox pb;
        int satirSayisi;
        int sutunSayisi;
        int kartYuksekligi = 100;
        int kartGenişliği = 100;
        int kartlarArasıMesafe = 10;
        int sayac = 0;
        int esiBulunanKartSayisi = 0;
        int sure = 0;
        int deneme = 0;
        int formGenisliği;
        int formYuksekligi;
        int toplamKartSayisi;
        int[] secilenKartNolari;
        int[] secilenTumKartNolari;
        List<PictureBox> pbTiklananKartlar = new List<PictureBox>();
        Random rnd = new Random();

        public FrmOyunAlani(int boyut)
        {
            satirSayisi = boyut;
            sutunSayisi = boyut;
            InitializeComponent();
            OyunuBaslat();
        }

        public void OyunuBaslat()
        {
            formGenisliği = sutunSayisi * kartGenişliği + (sutunSayisi - 1) * kartlarArasıMesafe + 40;
            formYuksekligi = satirSayisi * kartYuksekligi + (satirSayisi - 1) * kartlarArasıMesafe + 80;
            Size = new Size(formGenisliği, formYuksekligi);
            pnlKartlar.Size = new Size(formGenisliği, formYuksekligi);

            secilenTumKartNolari = KartlariKaristir(KartNolariSec(satirSayisi, sutunSayisi));
            for (int i = 0; i <= sutunSayisi - 1; i++)
            {
                for (int j = 0; j <= satirSayisi - 1; j++)
                {
                    pb = new PictureBox();
                    pb.Left = i * (kartGenişliği + kartlarArasıMesafe);
                    pb.Top = j * (kartYuksekligi + kartlarArasıMesafe);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = (Image)Resources.ResourceManager.GetObject("arka");
                    pb.Width = kartGenişliği;
                    pb.Height = kartYuksekligi;
                    pb.BackColor = Color.FromArgb(0, 153, 255);
                    pb.Tag = secilenTumKartNolari[sayac];
                    pb.Click += KartaTiklandiginda;
                    pnlKartlar.Controls.Add(pb);
                    sayac++;
                }
            }
        }

        public int[] KartNolariSec(int satirSayi, int sutunSayisi)
        {
            toplamKartSayisi = satirSayi * sutunSayisi;
            secilenKartNolari = new int[toplamKartSayisi / 2];
            secilenTumKartNolari = new int[toplamKartSayisi];

            for (int i = 0; i < toplamKartSayisi / 2; i++)
            {
                int rndSayi = rnd.Next(0, 263);
                if (!secilenKartNolari.Contains(rndSayi))
                    secilenKartNolari[i] = rndSayi;
                else
                    i--;
            }

            Array.Copy(secilenKartNolari, secilenTumKartNolari, secilenKartNolari.Length);
            Array.Copy(secilenKartNolari, 0, secilenTumKartNolari, secilenKartNolari.Length, secilenKartNolari.Length);
            return secilenTumKartNolari;
        }

        public int[] KartlariKaristir(int[] secilenKartNolari)
        {
            int temp;
            int talihliIndeks;

            for (int i= 0; i < secilenTumKartNolari.Length - 1; i++)
            {
                talihliIndeks = rnd.Next(i, secilenKartNolari.Length);
                temp = secilenTumKartNolari[i];
                secilenTumKartNolari[i] = secilenTumKartNolari[talihliIndeks];
                secilenTumKartNolari[talihliIndeks] = temp;
            }

            return secilenTumKartNolari;
        }

        private void KartaTiklandiginda(object sender, EventArgs e)
        {
            PictureBox pbTiklananKart = (PictureBox)sender;
             
            if(pbTiklananKartlar.Contains(pbTiklananKart))
            {
                return;
            }

            KartAc(pbTiklananKart);
            if (pbTiklananKartlar.Count == 2)
            {
                deneme++;
                lblDeneme.Text = "Deneme: " + deneme.ToString();
                Refresh();
                Thread.Sleep(600);
                if ((int)pbTiklananKartlar[0].Tag == (int)pbTiklananKartlar[1].Tag)
                {
                    
                    pbTiklananKartlar[0].Hide();
                    pbTiklananKartlar[1].Hide();
                    pbTiklananKartlar.Clear();
                    esiBulunanKartSayisi++;
                }
                else
                {
                    KartlariKapat();
                }

                if(esiBulunanKartSayisi == satirSayisi * sutunSayisi / 2)
                {
                    timer.Enabled = false;
                    this.Hide();
                    FrmOyunBitti frmOyunBitti = new FrmOyunBitti(deneme, sure);
                    frmOyunBitti.ShowDialog();
                }
            }
        }

        public void KartAc(PictureBox pbTiklananKart)
        {
            pbTiklananKart.Image = (Image)Resources.ResourceManager.GetObject("_" + (int)pbTiklananKart.Tag);
            pbTiklananKartlar.Add(pbTiklananKart);
        }

        public void KartlariKapat()
        {
            pbTiklananKartlar[0].Image = (Image)Resources.ResourceManager.GetObject("arka");
            pbTiklananKartlar[1].Image = (Image)Resources.ResourceManager.GetObject("arka");
            pbTiklananKartlar.Clear();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sure++;
            lblSure.Text = "Süre: " + sure + " sn.";
        }

        private void FrmOyunAlani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
