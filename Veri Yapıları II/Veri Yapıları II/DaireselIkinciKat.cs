using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_II
{
    class DaireselIkinciKat
    {
        public Araba Head;//işlemleri araba üzerinde yaptığımız için, (node)  bizim arabamız oluyor
        public Araba Last;
        public int count = 0;
        public void InsertLast(Araba Eklenen)
        {
            if (IsEmpty())//ilk deger  eklenme işinin yapıldığı yer
            {
                Head = Eklenen;
                Last = Eklenen;
                Last.Next = Head;
                Head.Next = Last;
            }
            else
            {
                Last.Next = Eklenen;//birden fazla node için girilen else fonksiyonu 
                Last = Eklenen;//yeni geleni sona ekleyerek son elemanın nex ini de head i göstererek döngüsel bir yapı oluşturulur
                Last.Next = Head;
            }
            count++;
        }
        public Araba DeletePosition(int position)//gelen değere göre silme işlemi
        {
            Araba temp = new Araba();
            Araba SilinenAraba = new Araba();
            temp = Head;
            if (IsEmpty())
                throw new Exception("Hata: Dairesel bağlı liste boş...");
            else if (position == 0)//silinecek son eleman kaldıysa 
            {
                if (count == 1)
                {
                    count--;
                    Head = null;
                    Last = null;
                    return temp;
                }
                else
                {
                    Last.Next = Head.Next;
                    Head = Head.Next;
                    count--;
                    return temp;
                }
            }
            else
            {
                for (int i = 0; i < position-1; i++)//birden fazla silinecek varsa  
                {
                    temp = temp.Next;//gelen parametreye kadar listede dolaşılır
                }
                SilinenAraba = temp.Next;//silinecek eleman bir değişkende tutulur
                temp.Next = temp.Next.Next;//silinenin bir öncesi bir sonrasını gösterir ve dairesel yapısı korunmuş olur
                count--;
                return SilinenAraba;
            }
            
        }
        public bool IsEmpty()
        {
            return count==0;
        }
    }
}
