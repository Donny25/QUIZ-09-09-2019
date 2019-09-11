using System;

namespace QUIZ09092019
{
    class bangundatar
    {
        public void luas_persegi()
        {
            Console.WriteLine("menghitung luas persegi");
            Console.WriteLine("------------------------");
            int sisi, luas;
            
            Console.Write("sisi= ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("luas persegi adalah "+luas);            
        }
        public void luas_segitiga()
        {
            Console.WriteLine("menghitung luas segitiga");
            Console.WriteLine("-------------------------");
            int alas, tinggi, luas_segitiga;
            
            Console.Write("alas= ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("tinggi= ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas_segitiga = alas * tinggi * 1/2; 

            Console.WriteLine("luas segitiga adalah "+luas_segitiga);
        }
        public void luas_lingkaran()
        {
            Console.WriteLine("menghitung luas lingkaran");
            Console.WriteLine("--------------------------");
            int r, luas_lingkaran;

            Console.Write("r= ");
            r = Convert.ToInt32(Console.ReadLine());

            luas_lingkaran = r * r * 22/7;
            
            Console.WriteLine("luas lingkaran adalah "+luas_lingkaran);

        }
    }
}
