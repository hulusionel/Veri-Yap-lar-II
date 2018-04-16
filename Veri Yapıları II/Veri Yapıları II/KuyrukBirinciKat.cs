using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_II
{
    class KuyrukBirinciKat
    {
        private Araba[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public KuyrukBirinciKat(int size)
        {
            this.size = size;
            Queue = new Araba[size];//size kadar ram dan boş yer alınır
        }
        public void Insert(Araba A)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)//ilk eklemede front 1 artar
                front = 0;
            if (rear == size - 1)//dizi tamamen dolduysa,doldurmaya dizinin başından devam edilir
            {
                rear = 0;
                Queue[rear] = A;
            }
            else
                Queue[++rear] = A;//hala son kısımlarda boş yer var ise sırayla doldurmaya devam eder

            count++;
        }

        public Araba Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            Araba temp = Queue[front];
            Queue[front] = null;//silme işlemi baştan yapılır
            if (front == size - 1)//dizinin son elemanında sonra hala silinecek değer var ise dizinin başına geri dönülür
                front = 0;
            else
                front++;

            count--;

            return temp;
        }

        public Araba Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            if (count == 0)
                return true;
            else
                return false;
        }
    }
}
