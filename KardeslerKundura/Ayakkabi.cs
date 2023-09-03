using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardeslerKundura
{
    public class Ayakkabi
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public byte Numara { get; set; }
        public short Stok { get; set; }

        public void Yazdir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Marka} ");
            Console.ForegroundColor = ConsoleColor.White;
            if (Stok> 0)
            {
                Console.WriteLine($"{Model}\nNumara = {Numara}\nFiyat = {Fiyat} TL\nStok = {Stok}\n");
            }
           else
            {
                Console.WriteLine($"{Model}\nNumara = {Numara}\nFiyat = {Fiyat} TL\nStok = Stokta Yok\n");
            }
        }
    }
}
