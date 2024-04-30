bool whileKontrol = true;
while (whileKontrol)
{
    Console.Clear();

    Console.WriteLine("Hesaplama Turunu Seciniz.\n");
    System.Console.WriteLine("[1] - Likide Hesapla");
    System.Console.WriteLine("[2] - Stop Hesapla\n");
    System.Console.Write("Kullanici girisi: ");
    int secim = Convert.ToInt16(Console.ReadLine());

    if (secim == 1)
    {
        Console.Clear();
        System.Console.WriteLine("Likide hesabi secildi...\n");
        System.Console.WriteLine("Poziyon turu seciniz.");
        System.Console.WriteLine("[1] - Long,\n[2] - Short");
        System.Console.Write("Kullanici secimi: ");
        int secimPositionType = Convert.ToInt16(Console.ReadLine());
        if (secimPositionType == 1)
        {
            Console.Clear();
            System.Console.WriteLine("Long islem icin Likide hesaplamasi yapilacaktir.");
            System.Console.Write("Pozisyon giris fiyatini giriniz: ");
            double girisFiyat = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Kaldirac X giriniz: ");
            double pozisyonX = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine($"\nIslemin Likidite fiyati {LongLikiditeHesapla(girisFiyat, pozisyonX)}\n");

            System.Console.WriteLine("Islem Seciniz\n[1] - Yeniden baslat\n[2] - Programi kapat");
            System.Console.Write("Kullanici secimi: ");
            int secim4 = Convert.ToInt16(Console.ReadLine());
            if (secim4 == 1)
            {
                whileKontrol = true;
            }
            else if (secim4 == 2)
            {
                whileKontrol = false;
            }
            else
            {
                System.Console.WriteLine("Farkli secim yapildigi icin uygulama yeniden baslatiliyor...");
                for (int i = 3; 0 < i; i--)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                whileKontrol = true;
            }

        }
        else if (secimPositionType == 2)
        {
            Console.Clear();
            System.Console.WriteLine("Short islem icin Likide hesaplamasi yapilacaktir.");
            System.Console.Write("Pozisyon giris fiyatini giriniz: ");
            double girisFiyat = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Kaldirac X giriniz: ");
            double pozisyonX = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine($"\nIslemin Likidite fiyati {ShortLikiditeHesapla(girisFiyat, pozisyonX)}\n");

            System.Console.WriteLine("Islem Seciniz\n[1] - Yeniden baslat\n[2] - Programi kapat");
            System.Console.Write("Kullanici secimi: ");
            int secim4 = Convert.ToInt16(Console.ReadLine());
            if (secim4 == 1)
            {
                whileKontrol = true;
            }
            else if (secim4 == 2)
            {
                whileKontrol = false;
            }
            else
            {
                System.Console.WriteLine("Farkli secim yapildigi icin uygulama yeniden baslatiliyor...");
                for (int i = 3; 0 < i; i--)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                whileKontrol = true;
            }
        }
    }
    else if (secim == 2)
    {
        double stopOrani;
        double girisFiyat;
        int islemTuru;
        Console.Clear();
        System.Console.WriteLine("Stop Hesaplama Secildi");
        System.Console.WriteLine("Poziyon turu seciniz.");
        System.Console.WriteLine("[1] - Long,\n[2] - Short");
        System.Console.Write("Kullanici secimi: ");
        islemTuru = Convert.ToInt16(Console.ReadLine());

        if (islemTuru == 1)
        {
            Console.Clear();
            System.Console.WriteLine("Long islem icin stop hesabi yapilacaktir.");
            System.Console.Write("Pozisyon giris fiyatini girin: ");
            girisFiyat = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Stop orani girin: ");
            stopOrani = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();

            System.Console.WriteLine($"\nStop noktasi: {StopHesapla(stopOrani, girisFiyat, 1)}\n");

            System.Console.WriteLine("Islem Seciniz\n[1] - Yeniden baslat\n[2] - Programi kapat");
            System.Console.Write("Kullanici secimi: ");
            int secim4 = Convert.ToInt16(Console.ReadLine());
            if (secim4 == 1)
            {
                whileKontrol = true;
            }
            else if (secim4 == 2)
            {
                whileKontrol = false;
            }
            else
            {
                System.Console.WriteLine("Farkli secim yapildigi icin uygulama yeniden baslatiliyor...");
                for (int i = 3; 0 < i; i--)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                whileKontrol = true;
            }
        }
        else if (islemTuru == 2)
        {
            Console.Clear();
            System.Console.WriteLine("Short islem icin stop hesabi yapilacaktir.");
            System.Console.Write("Pozisyon giris fiyatini girin: ");
            girisFiyat = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Stop orani girin: ");
            stopOrani = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();

            System.Console.WriteLine($"\nStop noktasi: {StopHesapla(stopOrani, girisFiyat, 2)}\n");

            System.Console.WriteLine("Islem Seciniz\n[1] - Yeniden baslat\n[2] - Programi kapat");
            System.Console.Write("Kullanici secimi: ");
            int secim4 = Convert.ToInt16(Console.ReadLine());
            if (secim4 == 1)
            {
                whileKontrol = true;
            }
            else if (secim4 == 2)
            {
                whileKontrol = false;
            }
            else
            {
                System.Console.WriteLine("Farkli secim yapildigi icin uygulama yeniden baslatiliyor...");
                for (int i = 3; 0 < i; i--)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                whileKontrol = true;
            }
        }
        else
        {
            bool doWhileKontrol = true;
            do
            {
                Console.Clear();

                System.Console.WriteLine("Yanlis Secim Yapildi\nIslem seciniz");
                System.Console.WriteLine("[1] - Yeniden baslat");
                System.Console.WriteLine("[2] - Programi kapat");
                System.Console.Write("Kullanici Giris: ");
                int secim2 = Convert.ToInt16(Console.ReadLine());

                if (secim2 == 1)
                {
                    whileKontrol = true;
                    doWhileKontrol = false;
                }
                else if (secim2 == 2)
                {
                    whileKontrol = false;
                    doWhileKontrol = false;
                }
                else
                {
                    doWhileKontrol = true;
                }
            } while (doWhileKontrol);

        }
    }
    else
    {
        bool doWhileKontrol = true;
        do
        {
            Console.Clear();

            System.Console.WriteLine("Yanlis Secim Yapildi\nIslem seciniz");
            System.Console.WriteLine("[1] - Yeniden baslat");
            System.Console.WriteLine("[2] - Programi kapat");
            System.Console.Write("Kullanici Giris: ");
            int secim2 = Convert.ToInt16(Console.ReadLine());

            if (secim2 == 1)
            {
                whileKontrol = true;
                doWhileKontrol = false;
            }
            else if (secim2 == 2)
            {
                whileKontrol = false;
                doWhileKontrol = false;
            }
            else
            {
                doWhileKontrol = true;
            }
        } while (doWhileKontrol);

    }
}


double LongLikiditeHesapla(double PozisyonGiris, double PozisyonX)
{
    return PozisyonGiris - (PozisyonGiris * ((100 / PozisyonX) / 100));
}
double ShortLikiditeHesapla(double PozisyonGiris, double PozisyonX)
{
    return PozisyonGiris + (PozisyonGiris * ((100 / PozisyonX) / 100));
}
double StopHesapla(double StopOran, double GirisFiyat, int islemTip)
{
    if (islemTip == 1)//long
    {
        return GirisFiyat - (GirisFiyat * (StopOran / 100));
    }
    else if (islemTip == 2)//short
    {
        return GirisFiyat + (GirisFiyat * (StopOran / 100));
    }
    else
    {
        return 0;
    }
}