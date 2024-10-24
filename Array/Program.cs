using System;

class Program
{
    static void Main()
    {
        // 1. Aşama: Dizi Tanımlama
        int[] dizi = new int[10]; // 10 elemanlı bir dizi oluşturma

        // 2. Aşama: Elemanları doldurma
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}. tam sayıyı giriniz: ");
            dizi[i] = int.Parse(Console.ReadLine()); // Kullanıcıdan sayı alma
        }

        // 3. Aşama: Dizi elemanlarını yazdırma
        Console.WriteLine("Dizi Elemanları:");
        foreach (var eleman in dizi)
        {
            Console.WriteLine(eleman); // Dizi elemanlarını yazdırma
        }

        // 4. Aşama: Yeni eleman ekleme
        Console.Write("Yeni bir tam sayı giriniz (11. eleman olarak): ");
        int yeniDeger = int.Parse(Console.ReadLine());
        Array.Resize(ref dizi, dizi.Length + 1); // Dizinin boyutunu artırma
        dizi[dizi.Length - 1] = yeniDeger; // Yeni değeri diziye ekleme

        // 5. Aşama: Diziyi büyükten küçüğe yazdırma
        Array.Sort(dizi); // Diziyi küçükten büyüğe sıralama
        Array.Reverse(dizi); // Diziyi büyükten küçüğe döndürme

        Console.WriteLine("Dizi Büyükten Küçüğe:");
        foreach (var eleman in dizi)
        {
            Console.WriteLine(eleman); // Sıralı diziyi yazdırma
        }
    }
}
