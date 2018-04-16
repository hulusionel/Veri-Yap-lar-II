using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_II
{
    class StackBodrumKat
    {
        private Araba[] items;
        private int top = -1;

        public StackBodrumKat(int itemCount)
        {
            this.items = new Araba[itemCount];//ram dan eklenecek eleman sayısı (size) kadar boş alan alınır
        }
        public void Push(Araba item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata: Stack doldu... (Overflow)");
            }
            items[++Top] = item;//dizinin başından sonuna sırayla elemanlar dizilir
        }

        public Araba Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Stack boş...(Downflow)");
            }
            Araba temp = items[Top--];//dizinin sonundan başına doğru tek tek elemanlar çıkarılır
            return temp;
        }

        public Araba Peek()
        {
            return items[Top];
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
