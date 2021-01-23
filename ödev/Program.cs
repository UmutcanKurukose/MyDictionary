using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Kitaplar = new MyDictionary<int, string>();
            Kitaplar.Add(1, "80 günde devri alem");
            Kitaplar.Add(2, "Hayvan Çiftliği");
            Kitaplar.Add(3, "1984");
            Kitaplar.Add(4, "Fahrenayt 451");
            
            Console.WriteLine(Kitaplar.Length);
            Console.WriteLine(Kitaplar);

        }
    }
}
