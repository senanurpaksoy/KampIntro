using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı",
                "programlaya başlangıç için temel kurs", "java","python" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            // kurs=  javadaki nesne ismi gibi s,e,c yazdığımız gibi  in kurslar=    kursları tek tek dolaş
            foreach (string kurs in kurslar)// foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");


            Console.WriteLine("YAŞI 10' DAN KÜÇÜKLER KURSA KAYDOLAMAZ ");
            Console.WriteLine("\nHER GRUBUN SADECE 32 KONTENJANI VAYDIR");
            int y;
            int kon;

            for(kon =0; kon>32;)
          
            {
                Console.WriteLine("\nLutfen yaşınızı giriniz: ");
                y = Convert.ToInt32(Console.ReadLine());

                if (y < 10)
                {
                    Console.WriteLine("Yaşınız 10 dan küçük olduğu için kursa kayıt olamazsınız");
                }

                if (y >= 10 && y < 14)
                {
                    Console.WriteLine("Yıldız Grup'a Kayıt Oldunuz");
                    kon++;
                    if (kon >= 32)
                    {
                        Console.WriteLine("KONTENJAN DOLU");
                    }

                }
                if (y >= 14 && y < 18)
                {
                    Console.Write("Genç Grup'a Kayıt Oldunuz");
                    kon++;
                    if (kon >= 32)
                    {
                        Console.WriteLine("KONTENJAN DOLU");
                    }
                }
                if (y >= 18)
                {
                    Console.Write("Büyük Grup'a Kayıt Oldunuz");
                    kon++;
                    if (kon >= 32)
                    {
                        Console.WriteLine("KONTENJAN DOLU");
                    }
                }

            } ///while (kon > 32);
        }
    }
}

