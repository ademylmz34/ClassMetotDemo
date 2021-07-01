using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +"\t"+ " isimli müşteri eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +"\t"+ " isimli müşteri silindi");
        }
    }
}
