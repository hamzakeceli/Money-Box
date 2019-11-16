using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kumbara
{
    public partial class Kumbaram : Form
    {
        public Kumbaram()
        {
            InitializeComponent();
        }


        Kumbara kumbara = new Kumbara();
        public double atılanToplamHacim = 0;
        public double biriktirilenPara = 0;
        int sayac = 0;



        private void Form1_Load_1(object sender, EventArgs e)
        {

            cmbPara.DataSource = Enum.GetNames(typeof(E_PAralar));
            lblBiriktirilen.Text = "0";
            lblToplamPara.Text = "0";
            lblToplamHacim.Text = "0";
        }


        private void BtnAT_Click(object sender, EventArgs e)
        {


            string paraAdi = cmbPara.SelectedItem.ToString();
            switch (paraAdi)
            {

                case "birkurus":
                    {
                        MadeniPara madeniPara = new MadeniPara();
                        madeniPara.adi = "birkurus";
                        madeniPara.degeri = 0.01;
                        madeniPara.capi = 17;
                        madeniPara.kalinligi = 1.65; //mm

                        toplamHacimYaz(madeniPara);
                        paraEkle(madeniPara);
                    }
                    break;
                case "beskurus":
                    {
                        MadeniPara madeniPara = new MadeniPara();
                        madeniPara.adi = "beskurus";
                        madeniPara.degeri = 0.5;
                        madeniPara.capi = 17;
                        madeniPara.kalinligi = 1.7; //mm
                        toplamHacimYaz(madeniPara);
                        paraEkle(madeniPara);
                    }
                    break;
                case "onkurus":
                    {
                        MadeniPara madeniPara = new MadeniPara();
                        madeniPara.adi = "onkurus";
                        madeniPara.degeri = 0.5;
                        madeniPara.capi = 19.25;
                        madeniPara.kalinligi = 1.7; //mm
                        toplamHacimYaz(madeniPara);
                        paraEkle(madeniPara);
                    }
                    break;
                case "ellikurus":
                    {
                        MadeniPara madeniPara = new MadeniPara();
                        madeniPara.adi = "ellikurus";
                        madeniPara.degeri = 0.5;
                        madeniPara.capi = 23.8;
                        madeniPara.kalinligi = 1.95; //mm
                        toplamHacimYaz(madeniPara);
                        paraEkle(madeniPara);
                    }
                    break;
                case "birtl":
                    {
                        MadeniPara madeniPara = new MadeniPara();
                        madeniPara.adi = "birtl";
                        madeniPara.degeri = 1;
                        madeniPara.capi = 26.15;
                        madeniPara.kalinligi = 1.95; //mm
                        toplamHacimYaz(madeniPara);
                        paraEkle(madeniPara);
                    }
                    break;
                case "bestl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "bestl";
                        kagitPara.degeri = 5;
                        kagitPara.en = 64;
                        kagitPara.boy = 13; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;
                case "ontl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "ontl";
                        kagitPara.degeri = 10;
                        kagitPara.en = 64;
                        kagitPara.boy = 13.6; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;
                case "yirmitl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "yirmitl";
                        kagitPara.degeri = 20;
                        kagitPara.en = 68;
                        kagitPara.boy = 142; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;
                case "ellitl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "ellitl";
                        kagitPara.degeri = 50;
                        kagitPara.en = 68;
                        kagitPara.boy = 148; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;
                case "yüztl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "yuztl";
                        kagitPara.degeri = 100;
                        kagitPara.en = 72;
                        kagitPara.boy = 154; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;
                case "ikiyuztl":
                    {
                        KagitPara kagitPara = new KagitPara();
                        kagitPara.adi = "ikiyuztl";
                        kagitPara.degeri = 200;
                        kagitPara.en = 72;
                        kagitPara.boy = 160; //mm
                        kagitPara.yukseklik = 0.25;
                        toplamHacimYaz(kagitPara);
                        paraEkle(kagitPara);

                    }
                    break;


                default:
                    MessageBox.Show("hatalı seçim");
                    break;



            }

            
            
            lblToplamPara.Text = biriktirilenPara.ToString();
            lblBiriktirilen.Text =  toplamParaHesap(kumbara).ToString();


        }

        private void BtnKır_Click(object sender, EventArgs e)
        {
            biriktirilenPara = 0;
            lblToplamPara.Text = 0.ToString();            
            lblToplamHacim.Text = 0.ToString();
            
            
            btnAT.Enabled = false;
            btnKır.Enabled = false;

        }

        private void BtnYapistir_Click(object sender, EventArgs e)
        {
            lblToplamHacim.Text = atılanToplamHacim.ToString();

            sayac++;
            if (sayac > 1)
            {
                
                MessageBox.Show("2 defa yapıştıramazsın!");
            }
            else
            {
                btnAT.Enabled = true;
                btnKır.Enabled = true;
                

            }


        }

        //paraya göre hacim hesap
        public void toplamHacimYaz(Para para)
        {
            atılanToplamHacim += para.HacipHesap();
            lblToplamHacim.Text = atılanToplamHacim.ToString();

        }

        //eklenen parayı kumbaraya ekleme
        public void paraEkle(Para para)
        {
            biriktirilenPara += para.degeri;
            if (atılanToplamHacim < Kumbara.toplamHacim)
            {
                kumbara.kumbaraParalar.Add(para);
            }
            else
            {
                MessageBox.Show($"Kumbara dolu {Kumbara.toplamHacim} hacmi aştınız!");
            }
        }

        //kumbara toplam para değeri
        public double toplamParaHesap(Kumbara kumbara)
        {
            double toplamPara = 0;
            foreach (Para para in kumbara.kumbaraParalar)
            {
                toplamPara += para.degeri;
            }
            //biriktirilenPara += toplamPara;
            return toplamPara;

        }

      


        
        
    }

}
