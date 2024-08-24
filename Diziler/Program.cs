using System;
class Program
{
    static void Main()
    {
        int[] sayilar = new int[10];

        for (int i = 0; i < sayilar.Length; i++)
        {
            //Kullanıcıdan 10 adey sayı istiyoruz.
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            sayilar[i] = Convert.ToInt32( Console.ReadLine() );
        }

        Console.WriteLine("\nGirilen Sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.Write("\nYeni bir sayı giriniz(11. sayı):");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        // Yeni bir dizi tanımlayarak mevcut dizinin boyutunu genişletiyoruz
        int[] yeniSayi1 = new int[sayilar.Length + 1];

        // Mevcut dizinin elemanlarını yeni diziye kopyalıyoruz
        for (int i = 0;i < sayilar.Length;i++)
        {
            yeniSayi1[i] = sayilar[i];
        }

        // Kullanıcıdan alınan 11. elemanı yeni dizinin sonuna ekliyoruz

        yeniSayi1[yeniSayi1.Length - 1] = yeniSayi;

        Array.Sort(yeniSayi1);// Küçükten büyüğe sıralar
        Array.Reverse(yeniSayi1); // Diziyi ters çevirir, böylece büyükten küçüğe sıralı olur

        // Büyükten küçüğe sıralanmış diziyi ekrana yazdırıyoruz
        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        foreach (int sayi in yeniSayi1)
        {
            Console.WriteLine(sayi);
        }
    }
}






    