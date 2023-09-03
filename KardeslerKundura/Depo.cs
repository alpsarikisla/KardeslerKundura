using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardeslerKundura
{
    public class Depo
    {
        Ayakkabi[] ayakkabilar;

        public Depo()
        {
            ayakkabilar = new Ayakkabi[0];
        }

        public void ekle(Ayakkabi nesne)
        {
            Ayakkabi[] gecici = new Ayakkabi[ayakkabilar.Length + 1];
            Array.Copy(ayakkabilar, gecici, ayakkabilar.Length);
            gecici[gecici.Length - 1] = nesne;
            ayakkabilar = gecici;
        }
        public void listele()
        {
            for (int i = 0; i < ayakkabilar.Length; i++)
            {
                Ayakkabi a = ayakkabilar[i];
                Console.Write($"\n{i + 1}) ");
                a.Yazdir();
            }
        }
        public void listele(byte p_numara)
        {
            for (int i = 0; i < ayakkabilar.Length; i++)
            {
                Ayakkabi a = ayakkabilar[i];
                //if (a.Numara == p_numara){}
                if (a.Numara <= p_numara+1 && a.Numara >= p_numara -1)
                {
                    Console.Write($"\n{i + 1}) ");
                    a.Yazdir();
                }
            }
        }
        public double satisYap(int urunno, short adet)
        {
            Ayakkabi a = ayakkabilar[urunno - 1];
            double toplamfiyat = 0;
            if (a.Stok >= adet)
            {
                toplamfiyat = a.Fiyat * adet;
                ayakkabilar[urunno - 1].Stok -= adet;
            }
            else
            {
                Console.WriteLine("Yeterli stok yok");
            }
            return toplamfiyat;
        }
    }
}
