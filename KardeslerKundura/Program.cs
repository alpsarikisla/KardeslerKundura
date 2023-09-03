using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardeslerKundura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();
            double toplam = 0;
            #region Ürün Ekleme

            Ayakkabi a1 = new Ayakkabi();
            a1.Marka = "Nike";
            a1.Model = "Air Jordan";
            a1.Numara = 46;
            a1.Fiyat = 12000;
            a1.Stok = 20;

            d.ekle(a1);

            Ayakkabi a2 = new Ayakkabi();
            a2.Marka = "Adidas";
            a2.Model = "Harden Step Back";
            a2.Numara = 45;
            a2.Fiyat = 9800;
            a2.Stok = 20;
            d.ekle(a2);

            #endregion

            string islem = "";
            Console.WriteLine("Merhaba Kardeşler Kundura Shop'a Hoş Geldiniz");
            

            string secenek = "e";
            while (secenek == "e")
            {
                #region Listeleme

                Console.WriteLine("1 - Numaraya Göre Listele");
                Console.WriteLine("2 - Tümünü Listele");
                Console.Write("İşlem Seçiniz = ");
                islem = Console.ReadLine();

                if (islem == "1")
                {
                    Console.Write("Numara Giriniz = ");
                    byte numara = Convert.ToByte(Console.ReadLine());
                    d.listele(numara);
                }
                else if (islem == "2")
                {
                    d.listele();
                }

                #endregion


                Console.WriteLine("Ürün no giriniz");
                int urunNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Adet = ");
                short adet = Convert.ToInt16(Console.ReadLine());

                toplam += d.satisYap(urunNo, adet);

                Console.WriteLine("Alışverişe Devam edelim? e/h");
                secenek = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Mersi Janım");
            
            Console.WriteLine("Toplam = " + toplam + " TL");

            if (toplam > 100000)
            {
                Console.WriteLine("Sağolasın ABİMMMMM");
            }
        }
    }
}
