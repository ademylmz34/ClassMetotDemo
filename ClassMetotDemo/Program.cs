using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Adi="Ali",
                Soyadi="Çelik",
                TelefonNo=5467897456
            };
            Musteri musteri2 = new Musteri()
            {
                Adi="Mesut",
                Soyadi="Yilmaz",
                TelefonNo=5369875245
            };
            Musteri musteri3 = new Musteri()
            {
                Adi="Hasan",
                Soyadi="Kaya",
                TelefonNo=5697825436
            };
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            Console.WriteLine("*************Müşterilerimiz****************");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi+"\t"+musteri.Soyadi+"\t"+musteri.TelefonNo);
            }
            Console.WriteLine();
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-------------Ekleme----------------");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
            }
            Console.WriteLine();
            Console.WriteLine("-------------Silme------------------");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Sil(musteri);
            }
            Console.ReadKey();
        }
    }
}
