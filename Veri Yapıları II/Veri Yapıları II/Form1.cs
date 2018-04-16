using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StackBodrumKat StackK = new StackBodrumKat(15);
        KuyrukBirinciKat KuyrukK = new KuyrukBirinciKat(15);
        DaireselIkinciKat DaireselK = new DaireselIkinciKat();
        
        public int Josephus(int elemanSayisi)
        {
            int[] elemanList = new int[elemanSayisi];//gelen parametre * integer kadar ram da boş alan tutulur
            int yasayanEleman = elemanSayisi;
            int sayac = 0,temp=0;
            int eleman = -1;
            for (int i = 0; i < elemanSayisi; i++)
            {
                elemanList[i] = 1;//tüm elemanlar canlı
            }
            while (yasayanEleman != 1)//döngüde son eleman kalmadığı sürece devam edicek
            {
                if (temp == elemanSayisi)
                    temp = 0;
                if (elemanList[temp] == 1)
                {
                    if (sayac == 1)//bir eleman canlı bir eleman ölü mantığının kodu
                    {
                        elemanList[temp] = 0;//tek sayılardaki elemanlar ölür
                        sayac = 0;
                        yasayanEleman--;
                    }
                    else
                        sayac++;
                }
                temp++;
            }
            for (int i = 0; i < elemanSayisi; i++)
            {
                if (elemanList[i] == 1)
                    eleman = i;
            }
            return eleman;
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            

            string yaz = "";
            for (int i = 1; i <= 15; i++)
            {
                Araba A = new Araba();
                A.arabaNumarasi = i;
                A.katBilgisi = 0;
                Araba B = new Araba();
                B.arabaNumarasi = i;
                B.katBilgisi = 1;
                Araba C = new Araba();
                C.arabaNumarasi = i;
                C.katBilgisi = 2;
                yaz += A.katBilgisi + ". kattaki " + A.arabaNumarasi + ". araba."+Environment.NewLine;
                yaz += B.katBilgisi + ". kattaki " + B.arabaNumarasi + ". araba."+Environment.NewLine;
                yaz += C.katBilgisi + ". kattaki " + C.arabaNumarasi + ". araba."+Environment.NewLine;
                StackK.Push(A);//arabalar stack,kuyruk ve dairesel bağlı listelere doldrulur
                KuyrukK.Insert(B);
                DaireselK.InsertLast(C);
            }
            txtEklenenler.Text = yaz;//tüm eklenen arabalar textbox a yazdırılır
           
        }

        private void btnArabaCikart_Click(object sender, EventArgs e)
        {
           
            string yaz = "";
            Random rnd = new Random();
            int randomSayi;
            int daireselKalan = 15;
            Araba temp = new Araba();
            while (StackK.IsEmpty()==false || DaireselK.count !=0)//kuyruk boş olmadığı ve eleman sayısı 0 olmadığı sürece devam eder
            {
                randomSayi = rnd.Next(0, 2);
                if (KuyrukK.IsEmpty())
                    break;
                else if (randomSayi == 0)
                {
                    if (StackK.IsEmpty() == false)//stack ta eleman bittiğinde hata vermemesi kontrolünü yapar
                    {
                        temp = KuyrukK.Remove();//kuyrukta hala eleman varsa ve random değer 0 geldiyse eleman çıkarır
                        KuyrukK.Insert(StackK.Pop());//çıkan elemanı ilk kata ekler
                        yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                    }
                    else
                        continue;
                }
                else if (randomSayi == 1)
                {
                    if (DaireselK.count != 0)
                    {
                        temp = KuyrukK.Remove();//orta katımızdan bir eleman çıkar
                        KuyrukK.Insert(DaireselK.DeletePosition(Josephus(daireselKalan)));
                        daireselKalan--;
                        yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                    }
                    else
                        continue;
                }
            }
            if (KuyrukK.IsEmpty() == false)
            {
                for (int i = 0; i < 15; i++)
                {
                    temp = KuyrukK.Remove();
                    yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                }
            }
            txtCikanlar.Text = yaz;
          
        }

        private void btnBesSaniye_Click(object sender, EventArgs e)//programın 5 sn bekledikten sonra ortalama ne kadar problem çözeceğini ekrana gösterir
        {
            DateTime BaslangicZamani = DateTime.Now;//butona tıklandığı anki zamanı  alır
            int cozumSayisi = 0;
            while (DateTime.Now.Second - BaslangicZamani.Second < 5)//şu anki ve butona tıklanan anki saniye 5 ten küçük oldukça çalıştırıcak
            {
                string yaz = "";
                for (int i = 1; i <= 15; i++)
                {
                    Araba A = new Araba();
                    A.arabaNumarasi = i;
                    A.katBilgisi = 0;
                    Araba B = new Araba();
                    B.arabaNumarasi = i;
                    B.katBilgisi = 1;
                    Araba C = new Araba();
                    C.arabaNumarasi = i;
                    C.katBilgisi = 2;
                    yaz += A.katBilgisi + ". kattaki " + A.arabaNumarasi + ". araba." + Environment.NewLine;
                    yaz += B.katBilgisi + ". kattaki " + B.arabaNumarasi + ". araba." + Environment.NewLine;
                    yaz += C.katBilgisi + ". kattaki " + C.arabaNumarasi + ". araba." + Environment.NewLine;
                    StackK.Push(A);
                    KuyrukK.Insert(B);
                    DaireselK.InsertLast(C);
                }
                txtEklenenler.Text = yaz;
                yaz = "";
                Random rnd = new Random();
                int randomSayi;
                int daireselKalan = 15;
                Araba temp = new Araba();
                while (StackK.IsEmpty() == false || DaireselK.count != 0)
                {
                    randomSayi = rnd.Next(0, 2);
                    if (randomSayi == 0)
                    {
                        if (StackK.IsEmpty() == false)
                        {
                            temp = KuyrukK.Remove();
                            KuyrukK.Insert(StackK.Pop());
                            yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                        }
                        else
                            continue;
                    }
                    else if (randomSayi == 1)
                    {
                        if (DaireselK.count != 0)
                        {
                            temp = KuyrukK.Remove();
                            KuyrukK.Insert(DaireselK.DeletePosition(Josephus(daireselKalan)));
                            daireselKalan--;
                            yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                        }
                        else
                            continue;
                    }
                }
                for (int i = 0; i < 15; i++)
                {
                    temp = KuyrukK.Remove();
                    yaz += temp.katBilgisi + ". kattaki " + temp.arabaNumarasi + ". araba." + Environment.NewLine;
                }
                txtCikanlar.Text = yaz;
                cozumSayisi++;
            }
            lblCozumMiktari.Text = cozumSayisi.ToString();
            cozumSayisi = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
