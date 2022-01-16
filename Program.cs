using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort, sıralama
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 17, 11};

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear, dizi içerisindeki verilen indexten verilen uzunluk kadar elemanları 0 yapar
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse, verilen diziyi ters çevirir
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf, verilen dizide verilen elemanın hangi indexte olduğunu döndürür.
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            // Resize, verilen dizinin boyutunu yeniden düzenler.
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
