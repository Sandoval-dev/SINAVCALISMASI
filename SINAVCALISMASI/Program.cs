using System;
using System.Collections;


namespace SINAVCALISMASI
{
    class Program
    {

        static void Main(string[] args)
        {

            #region GİRİLEN SAYILARA GÖRE İŞLEM SEÇTİRİP YAPAN PROGAM
            //Console.WriteLine(" GİRİLEN SAYILARA GÖRE İŞLEM YAPAN PROGAM: ");

            //Console.WriteLine(" Bir Sayı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" İkinci Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" 1--> Toplama // 2--> Çıkarma // 3--> Çarpma // 4--> Bölme ");
            //int islem = Convert.ToInt32(Console.ReadLine());

            //if (islem == 1)
            //{
            //    Console.WriteLine(" Toplama İşlemini Seçtiniz. Sonuç: {0} ", sayi1 + sayi2);
            //}
            //else if (islem==2)
            //{
            //    Console.WriteLine(" Çıkarma İşlemini Seçtiniz. Sonuç: {0} ", sayi1 - sayi2);
            //}
            //else if (islem == 3)
            //{
            //    Console.WriteLine(" Çarpma İşlemini Seçtiniz. Sonuç: {0} ", sayi1 * sayi2);
            //}     
            //else if (islem == 4)
            //{
            //    if (sayi2 == 0)
            //    {
            //        Console.WriteLine(" Bölen Sayı Sıfır Olamaz. ");
            //    }

            //    if (sayi2 != 0)
            //    {
            //        Console.WriteLine(" Bölme İşlemini Seçtiniz. Sonuç: {0} ", (float)sayi1 / (float)sayi2 );

            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Yanlış Seçim Yaptınız. Tekrar Deneyiniz. ");
            //}
            //Console.ReadLine();
            #endregion

            #region ÖĞRENCİNİN VİZE VE FİNAL ORTALAMASINA GÖRE NOTUNU SÖYLEYEN PROGAM
            //#region ÖĞRENCİNİN VİZE VE FİNAL ORTALAMASINA GÖRE NOTUNU SÖYLEYEN PROGAM

            //Console.WriteLine("ÖĞRENCİNİN VİZE VE FİNAL ORTALAMASINA GÖRE NOTUNU SÖYLEYEN PROGAM");

            //Console.WriteLine(" Vize notunu giriniz: ");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Final notunu giriniz: ");
            //int final = Convert.ToInt32(Console.ReadLine());

            //int ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            //Console.WriteLine(" Ortalamanız: {0} ", ort);


            //if( ort<45 || final < 50)
            //{
            //    Console.WriteLine(" Kaldın. TEKRAR DENE. ");
            //}
            //else if (ort>45 && final < 50)
            //{
            //    Console.WriteLine(" TEBRİKLER. Kaldınız. ");
            //}
            //else if (ort >=45 && final >= 50)
            //{
            //    Console.WriteLine(" Hayret Geçtin. ");
            //}
            //else if (ort <45 || final >= 50)
            //{
            //    Console.WriteLine(" Kaldın Hayırlı Olsun. ");
            //}




            //Console.ReadLine();
            #endregion

            #region ÖĞRENCİNİN SINIFINA GÖRE BOŞ YAPAN PROGAM

            //Console.WriteLine(" ÖĞRENCİNİN SINIFINA GÖRE BOŞ YAPAN PROGAM ");

            //Console.WriteLine(" Kaçıncı Sınıfsınız: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case (1):
            //        Console.WriteLine(" Yeni Gelmişsin. ");
            //        break;

            //    case (2):
            //        Console.WriteLine(" Artık Buralardansın. ");
            //        break;

            //    case (3):
            //        Console.WriteLine(" Ev Sahibi Sensin. ");
            //        break;

            //    case (4):
            //        Console.WriteLine(" Misafirsin. ");
            //        break;

            //    default:
            //        Console.WriteLine(" Okul Uzamış Kanka. ");
            //        break;

            //        Console.ReadLine();
            //}

            #endregion

            #region TL CİNSİNDEN GİRİLEN PARAYI EURO VEYA DOLARA ÇEVİREN PROGAM

            //Console.WriteLine("TL CİNSİNDEN GİRİLEN PARAYI EURO VEYA DOLARA ÇEVİREN PROGAM ");

            //Console.WriteLine(" Kaç TL niz Olduğunu Giriniz: ");
            //int tl = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Paranızı Euro'ya çevirmek için 1'e, Dolar'a çevirmek için 2'ye basınız: ");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //switch (secim)
            //{
            //    case (1):
            //        Console.WriteLine(" Euro'ya çevirmek istediniz. Toplam paranız: {0} ", tl / 6.39);
            //        break;

            //    case (2):
            //        Console.WriteLine(" Dolar'a çevirmek istediniz. Toplam paranız: {0} ", tl / 5.76);
            //        break;

            //    default:
            //        Console.WriteLine(" Yanlış bir tuşlama yaptınız. ");
            //        break;
            //}
            //Console.ReadLine();
            #endregion

            #region SONSUZ FOR DÖNGÜSÜ

            //for (; ; )
            //{
            //    Console.WriteLine(" BEN MUHTEŞEMİM");
            //}
            //Console.ReadLine();
            #endregion

            #region 1-100 ARASINDAKİ 3 VE 5 İLE BÖLÜNEBİLEN SAYILAR

            // Console.WriteLine(" 1-100 ARASINDAKİ 3 VE 5 İLE BÖLÜNEBİLEN SAYILAR ");

            //for (int i=1; i<101; i++)
            // {
            //     if ((i % 3 == 0) && (i % 5 == 0))
            //         Console.WriteLine(i);
            // }

            // Console.ReadLine();
            #endregion

            #region 1-9999 ARASINDAKİ 5 VE 7 İLE TAM BÖLÜNEBİLEN SAYILAR

            //Console.WriteLine(" 1-9999 ARASINDAKİ 5 VE 7 İLE TAM BÖLÜNEBİLEN SAYILAR ");

            //for (int i = 1; i < 9999; i++)
            //{
            //    if (i % 5 == 0 && i % 7 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();
            #endregion

            #region Kullanıcıdan 10 adet isim alarak başına numaraların da ekleyerek ekranda yazdıran PROGAM
            //string isim;
            //Console.WriteLine(" İsminiz nedir? ");
            //isim = Console.ReadLine();

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine("{0}. {1} ", i, isim);
            //}
            //Console.ReadKey();
            #endregion

            #region 100 DEFA BEN MUHTEŞEMİM YAZAN PROGAM

            //for(int i=1; i <101; i++)
            //{
            //    Console.WriteLine(" BEN MUHTEŞEMİM ");
            //}
            //Console.ReadLine();
            #endregion

            #region KULLANICININ GİRMİŞ OLDUĞU METNİ 1000 DEFA YAZDIRAN PROGAM
            //string metin;
            //Console.WriteLine(" Bir metin giriniz: ");
            //metin = Console.ReadLine();
            //Console.WriteLine("--------------");

            //for(int i=1; i<1001; i++)
            //{
            //    Console.WriteLine(metin);
            //}
            //Console.ReadLine();
            #endregion

            #region 1-2000 ARASI 3 İLE TAM BÖLÜNEMEYEN SAYILAR

            //for(int i=1; i<2001; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region KULLANICIDAN GİRİLEN İKİ SAYI ARASINDAKİ SAYILARI LİSTELEYEN PROGAM

            //Console.Write("1. Sayıyı girin:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı girin:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            #endregion

            #region ALIŞVERİŞ TUTARINA GÖRE KARGO PARASINI HESAPLAYAN PROGAM

            //Console.WriteLine("ALIŞVERİŞ TUTARINA GÖRE KARGO PARASINI HESAPLAYAN PROGAM ");


            //Console.WriteLine(" Alışveriş tutarını giriniz: ");
            //int tutar = Convert.ToInt32(Console.ReadLine());

            //if (tutar < 10)
            //{
            //    Console.WriteLine(" Ödemeniz gereken tutar: {0} ", (tutar + 15) + " 15 tl kargo eklenmiştir" );
            //}
            //else if (tutar <= 50)
            //{
            //    Console.WriteLine(" Ödemeniz gereken tutar: {0} ", tutar + 10 + " 10 tl kargo eklenmiştir ");
            //}
            // else if (tutar > 60)
            //{
            //    Console.WriteLine(" Ödemeniz gereken tutar: {0} ", tutar + " kargo ücretsizdir ");
            //}

            //Console.ReadLine();
            #endregion

            #region FAKTÖRİYEL HESAPLAMA UYGULAMASI
            //int i, sayi, fakt = 1;
            //Console.WriteLine(" Faktöriyeli Hesaplanacak Sayıyı Giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for(i=1; i<=sayi; i++)
            //{
            //    fakt = fakt * i;
            //}
            //Console.WriteLine(" Sonuç: {0} ", fakt);
            //Console.ReadLine();
            #endregion

            #region ÇARPIM TABLOSU 

            //for(int i=1; i<10; i++)
            //{
            //    for(int k=i; k<10; k++)
            //    {
            //        Console.WriteLine(" {0}x{1}={2} ", i, k, i * k);
            //    }
            //    Console.WriteLine("-----");

            //}
            //Console.ReadLine();
            #endregion

            #region KLAVYEDEN GİRİLEN SAYI TEK Mİ ÇİFT Mİ SÖYLEYEN PROGAM

            //Console.WriteLine(" Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine(" Sayınız Çifttir.");
            //}
            //else
            //    Console.WriteLine(" Sayınız Tektir.");
            //Console.ReadLine();
            #endregion

            #region TAM BÖLÜNME-BÖLÜNMEME PROGAMI

            //Console.WriteLine(" birinci sayıyı girin:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" ikinci sayıyı girin: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 % sayi2 == 0)
            //{
            //    Console.WriteLine(" Tam bölünüyor. ");
            //}
            //else
            //{
            //    Console.WriteLine(" Tam bölünmüyor. ");
            //}
            //Console.ReadLine();
            #endregion

            #region EHLİYET ALABİLME UYGULAMASI
            //int yas, fark = 1;
            //Console.WriteLine(" Lütfen yaşınızı giriniz: ");
            //yas = Convert.ToInt32(Console.ReadLine());

            //if (yas >= 18)
            //{
            //    Console.WriteLine(" Ehliyet almak için uygunsunuz. ");
            
            //else
            //{
            //    fark = 18 - yas;
            //    Console.WriteLine(" Ehliyet alamazsınız. Ehliyet almak için {0} yıl beklemeniz gerek.", fark);
            //}
            //Console.ReadLine();
            #endregion

            #region  GİRİLEN 3 SAYIDAN EN BÜYÜĞÜNÜ GÖSTEREN PROGAM
            //int sayi1, sayi2, sayi3 = 1;
            //Console.WriteLine(" Birinci sayıyı giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" İkinci sayıyı giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Üçüncü sayıyı giriniz: ");
            //sayi3=Convert.ToInt32(Console.ReadLine());

            //if(sayi1>sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine(" En büyük sayı: {0} ", sayi1);
            //}
            //else if(sayi2>sayi1 && sayi2 > sayi3)
            //{
            //    Console.WriteLine(" En büyük sayı: {0} ", sayi2);
            //}
            //else if (sayi3>sayi2 && sayi3 > sayi1)
            //{
            //    Console.WriteLine(" En büyük sayı: {0} ", sayi3);
            //}
            //Console.ReadLine();

            #endregion

            #region GİRİLEN SAYI ÇİFT İSE YARISINI TEK İSE İKİ KATINI EKRANDA GÖSTEREN PROGAM

            //Console.WriteLine(" Sayıyı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine(" {0} ", sayi / 2);
            //}
            //else
            //{
            //    Console.WriteLine(" {0} ", sayi * 2);
            //}
            //Console.ReadLine();
            #endregion

            #region KLAVYEDEN GİRİLEN SAYININ İSTEĞE BAĞLI KARESİ KÜPÜ KAREKÖKÜNÜ ALAN PROGAM

            //Console.WriteLine(" Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Ne yapmak istediğiniz seçin: 1==> Karesini al || 2==> Küpünü al || 3==> Karekökünü al");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim == 1)
            //{
            //    Console.WriteLine(" Kare almayı seçtiniz. Sonuç: {0} ", sayi * sayi);
            //}
            //else if (secim == 2)
            //{
            //    Console.WriteLine(" Küp almayı seçtiniz. Sonuç: {0}", sayi * sayi * sayi);
            //}
            //else if (secim == 3)
            //{

            //    Console.WriteLine(" Kök almayı seçtiniz. Sonuç: {0} ", Math.Sqrt(sayi));
            //}
            #endregion

            #region Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan %3, daha fazla olanlardan ise %2 komisyon almaktadır. Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.

            //double malfiyati = 0, komisyonmiktari = 0, toplamkomisyon = 0;
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine(" {0}. malın fiyatını giriniz: ", i + 1);
            //    malfiyati = Convert.ToDouble(Console.ReadLine());
            //    if (malfiyati > 50) komisyonmiktari = malfiyati * 0.02;
            //    else komisyonmiktari = malfiyati * 0.03;
            //    Console.WriteLine(" {0}. mal için komisyon miktarı: {1} ", i + 1,( komisyonmiktari));
            //    toplamkomisyon += komisyonmiktari;
            //}
            //Console.WriteLine(" Toplam Komisyon Miktarı: {0} ", toplamkomisyon);
            //Console.ReadLine();
            #endregion

            #region ÖĞRENCİ HESABI NOTU PROGAMI
            //int basarisiz = 0, basarili = 0, orta = 0;
            //Console.WriteLine(" Öğrenci sayısını giriniz: ");
            //int ögrencisayisi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < ögrencisayisi;)
            //{
            //    Console.WriteLine(" Puanı giriniz: ");
            //    int puan = Convert.ToInt32(Console.ReadLine());
            //    if (puan < 0 || puan > 100)
            //    {
            //        Console.WriteLine(" yanlış bir puan girdiniz.");
            //    }
            //    else if (puan > 0 && puan <= 40)
            //    {
            //        basarisiz++;
            //        i++;
            //    }
            //    else if (puan > 40 && puan < 70)
            //    {
            //        orta++;
            //        i++;
            //    }
            //    else
            //    {
            //        basarili++;
            //        i++;

            //    }

            //    Console.WriteLine(" {0} öğrenciden {1} başarılı, {2} başarısız, {3} orta durumdadır.", ögrencisayisi, basarili, basarisiz, orta);
            //    Console.ReadLine();
        }
            #endregion

            #region ASAL SAYILARI BULAN PROGAM 
            //int sayac = 0;
            //for (int i = 2; i < 100; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i%j==0)
            //        {
            //            sayac++;

            //        }


            //    }
            //    if (sayac == 2)
            //    {
            //        Console.WriteLine(" {0} sayısı asal sayıdır. ",i);
            //        sayac = 0;
            //    }
            //    else
            //    {
            //        sayac = 0;
            //    }    

            //}
            //Console.ReadLine();
            #endregion

            #region FARKLI SAYILARI TOPLAYAN PROGAM
            //int sayi = 0, toplam = 0, biröncekisayi = 0;
            //for (; ; )
            //{
            //    Console.WriteLine(" Bir sayı giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //        break;
            //    else if (sayi == biröncekisayi)
            //    {
            //        Console.WriteLine(" Lütfen farklı bir sayı girin. ");
            //    }
            //    toplam += sayi;
            //    biröncekisayi = sayi;
            //}
            //Console.WriteLine(" Sayıların Toplamı: {0} ", toplam);
            //Console.ReadLine();
            #endregion

            #region SINAV ORTALAMALARINA GÖRE ÖĞRENCİYE NE YAPMASI GEREKTİĞİNİ SÖYLEYEN PROGAM


            //Console.WriteLine(" Birinci Sınav Notunu Giriniz: ");
            //int not1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" İkinci Sınav Notunu Giriniz: ");
            //int not2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(" ORTALAMANIZ: {0} ", (not1+not2)/2);
            //int ort = Convert.ToInt32(Console.ReadLine());
            //if(ort < 50)
            //{
            //    Console.WriteLine(" Ortalamanız 50 den düşük. Üçüncü sınava girmeniz gerekmektedir. ");
            //    Console.Write(" Üçüncü sınav notunu giriniz: ");
            //    int not3 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(" Ortalamanız: {0} ", (not1 + not2 + not3));
            //}

            //else
            //{
            //    Console.WriteLine(" Tebrikler Geçtiniz. ");
            //}

            #endregion

            #region FOR İLE UFAK BİR UYGULAMA

            //Console.WriteLine(" İstediğiniz bir metin giriniz: ");
            //string metin = Convert.ToString(Console.ReadLine());

            //Console.WriteLine(" Tekrar sayısını giriniz: ");
            //int tekrar = Convert.ToInt32(Console.ReadLine());

            //for(int i=1; i<=tekrar; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.WriteLine(metin);
            //    }

            //    Console.WriteLine(" Osman Bey ");
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 1 

            //int toplam = 0;
            //int sayac = 0;
            //int[] dizi = { 1, 3, 4, 5, 7, 2, 9, 8, 4, 6, 14, 23, 15 };
            //for(int i=0; i<dizi.Length; i++)
            //{
            //    if (dizi[i] % 2 == 1)
            //    {
            //        sayac++;
            //        toplam = toplam + dizi[i];
            //    }
            //}
            //Console.WriteLine(" Sayıların Adedi: {0} ", sayac);
            //Console.WriteLine(" Sayıların Toplamı: {0} ", toplam);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 2

            //Console.WriteLine(" Dizinin kaç elemanlı olmasını istediğiniz giriniz: ");
            //double toplam = 0;
            //double ortalama;
            //int gelen = Convert.ToInt32(Console.ReadLine());
            //int[] sayılar = new int[gelen];
            //for(int i=0; i<sayılar.Length; i++)
            //{
            //    Console.WriteLine(" Sayı giriniz: ");
            //    sayılar[i] = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + sayılar[i];
            //    Console.WriteLine(" Sayıların Toplamı: {0} ", toplam);
            //}
            //ortalama = toplam / gelen;
            //Console.WriteLine(" Sayıların Ortalaması: {0} ", ortalama);
            #endregion

            #region DİKDÖRTGEN YAPMA UYGULAMASI

            //static void Main(string[] args)
            //{
            //    Console.WriteLine(" Kısa kenar uzunluğunu giriniz: ");
            //    int kısakenar = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" Uzun kenar uzunluğunu giriniz: ");
            //    int uzunkenar = Convert.ToInt32(Console.ReadLine());
            //    Dikdörtgen(uzunkenar, kısakenar);
            //    Console.ReadLine();
            //}
            //static int Dikdörtgen(int uzunkenar, int kısakenar)
            //{
            //    for (int i = 1; i <= uzunkenar; i++)
            //    {
            //        for (int j = 1; j <= kısakenar; j++)
            //        {
            //            if (i == 1 || i == uzunkenar)
            //                Console.Write("*");
            //            else if (j == 1 || j == kısakenar)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");

            //        }
            //        Console.WriteLine();
            //    }
            //    return uzunkenar + kısakenar;
            //}


            #endregion

            #region DİZİ ÖRNEK 3 

            //int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(dizi[i, j]);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 4

            //string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            //for(int i=0; i<gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 5
            //int[] sayilar = { 13, 25, 54, 22, 1, 43, 32, 55 };
            //int toplam = 0;
            //double ortalama;
            //for(int i=0; i<sayilar.Length; i++)
            //{
            //    toplam = toplam +sayilar[i];
            //}
            //ortalama = toplam / sayilar.Length;
            //Console.WriteLine(" Sayıların Toplamı: {0} ", toplam);
            //Console.WriteLine(" Sayıların Ortalaması: {0} ", ortalama);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 6 
            //int[] dizi = new int[5];
            //for(int i=0; i<dizi.Length; i++)
            //{
            //    Console.WriteLine(" {0}. sayıyı giriniz: ", i + 1);
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi > 100)
            //    {
            //        dizi[i] = sayi;
            //    }

            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 7
            //int[] dizi = { 17, 15, 45, 78, 92, 35, 6, 85, 72, 522, 45, 12, 45, 866, 71, 25, 42, 63, 20, 13, 16, 18, 95, 45, 624, 71 };
            //int sayi, kontrol = 0;
            //Console.WriteLine(" Dizide aramak istediğiniz sayıyı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for(int i=0; i<dizi.Length; i++)
            //{
            //    if (sayi == dizi[i])
            //    {
            //        kontrol++;
            //    }
            //}
            //if (kontrol == 0)
            //{
            //    Console.WriteLine(" Aradığınız sayı dizide bulunmamaktadır. ");
            //}
            //else
            //    Console.WriteLine("Aradığınız sayı dizide {0} adet bulunmaktadır. ", kontrol);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 8
            //int sayac = 0;
            //int[] dizi = { 17, 15, 45, 78, 92, 35, 6, 85, 72, 522, 45, 12, 45, 866, 71, 25, 42, 63, 20, 13, 16, 18, 95, 45, 624, 71 };
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] % 2 == 1)
            //    {
            //        sayac++;
            //        Console.WriteLine(dizi[i]);
            //    }
            //}
            //Console.WriteLine(" Tek sayıların adedi: {0} ", sayac);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 9
            //char[] dizi1 = { 'a', 'e', 'ö', 'ı', 'ü', 'o', 'u', 'i' };
            //Console.WriteLine(" Bir metin giriniz: ");
            //string metin = Convert.ToString(Console.ReadLine());
            //int sayac1 = 0;
            //for(int i=0; i<dizi1.Length; i++)
            //{
            //    for(int j=0; j<dizi1.Length; j++)
            //    {
            //        if (metin[i] == dizi1[j])
            //        {
            //            sayac1++;
            //        }
            //    }
            //}
            //Console.WriteLine(" Metininizde {0} adet sesli harf vardır. ");
            //Console.ReadLine(); 

            #endregion

            #region DİZİ ÖRNEK 10

            //string[] isimler = { "osman", "memet", "erdem", "kılıç", "ahmet" };
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 11

            //int[] dizi = new int[5];
            //double toplam = 0;
            //double ortalama;

            //for(int i=0; i<dizi.Length; i++)
            //{
            //    Console.WriteLine(" Dizinin {0}. elemanını giriniz: ", i+1);
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine(" Dizinizdeki sayıların toplamı: {0} ", toplam);
            //}
            //ortalama = toplam / dizi.Length;
            //Console.WriteLine(" Dizinizin Ortalaması: {0} ", ortalama);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 12

            //char[] sesli = { 'a', 'e', 'u', 'ı', 'i', 'ü', 'o', 'ö' };
            //Console.WriteLine(" Bir metin giriniz: ");
            //string metin = Convert.ToString(Console.ReadLine());
            //int sayac = 0;
            //for(int i=0; i<sesli.Length; i++)
            //{
            //    for(int j=0; j<metin.Length; j++)
            //    {
            //        if (sesli[i] == metin[j])
            //        {
            //            sayac++;
            //        }
            //    }
            //}
            //Console.WriteLine(" Metininizde {0} adet sesli harf vardır. ", sayac);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 13
            //int[] sayilar = { 123, 324, 653, 213, 323, 7656, 244, 767, 3434, 13, 2345, 7887, 098, 567, 55, 34, 76, 333, 22 };
            //int sayac = 0;
            //for(int i=0; i<sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 1)
            //    {
            //        sayac++;
            //    }
            //}
            //foreach(int sayi in sayilar)
            //{
            //    if(sayi%2==1)
            //    Console.WriteLine(" Dizinizdeki tek sayılardan biri şudur: {0}", sayi);
            //}
            //Console.WriteLine(" Dizinizde {0} adet tek sayı vardır. ", sayac);
            //Console.ReadLine();
            #endregion

            #region ARRAY LİST 

            //ArrayList liste = new ArrayList();
            //liste.Add("ataberk");
            //liste.Add("emre");
            //liste.Add("ali");
            //liste.Add("berat");
            //Console.WriteLine(liste[2]);

            //foreach(string eleman in liste)
            //{
            //    Console.WriteLine(eleman);
            //}
            //Console.ReadLine();
            #endregion

            #region ARRAY LİST ÖRNEK 1 

            //ArrayList ciftsayilar = new ArrayList();
            //ArrayList teksayilar = new ArrayList();
            //double ortalama;
            //double toplam = 0;
            //Random rnd = new Random();
            //for(int i=0; i<10; i++)
            //{
            //    int sayi = rnd.Next(1, 100);
            //    Console.Write(sayi + "  ");
            //    toplam += sayi;
            //    if (sayi % 2 == 0)
            //    {
            //        ciftsayilar.Add(sayi);
            //    }
            //    else
            //    {
            //        teksayilar.Add(sayi);
            //    }

            //}
            //Console.WriteLine(" ====================== ");
            //ortalama = toplam / 10;
            //Console.WriteLine(" Sayıların toplamı: {0} . Sayıların Ortalaması: {1}", toplam, ortalama);
            //Console.WriteLine(" Tek sayıların adedi: {0}", teksayilar.Count);
            //Console.WriteLine(" Çift sayıların adedi: {0} ", ciftsayilar.Count);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 14

            //string kelime = "";
            //int sonuc = 0;
            //Console.WriteLine(" Metni giriniz: ");
            // string metin = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(" Sözcüğü giriniz: ");
            //string sözcük = Convert.ToString(Console.ReadLine());
            //for(int i=0; i<metin.Length; i++)
            //{
            //    if (metin[i] != ' ')
            //    {
            //        kelime = kelime + metin[i];
            //    }
            //    else
            //    {
            //        if (kelime == sözcük)
            //        {
            //            sonuc++;
            //        }
            //        kelime = "";
            //    }

            //}
            //Console.WriteLine(" Sonuç {0}", sonuc);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 15

            //int[] dizi = new int[10];
            //for(int i=0; i<dizi.Length; i++)
            //{
            //    Console.WriteLine(" Dizinin {0}. elemanını giriniz. ", i + 1);
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(" =============== ");
            //for(int i=0; i<dizi.Length; i++)
            //{
            //    dizi[i] = dizi[i] + (dizi[i] / 20 * 100);
            //    Console.WriteLine(" Dizinin {0}. elemanının indexi: {1}", i, dizi[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 16

            //Console.WriteLine(" Sınıf mevcudunu giriniz: ");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] sınıf = new string[mevcut];
            //for(int i=0; i<sınıf.Length; i++)
            //{
            //    Console.WriteLine(" Sınıftaki {0}. kişinin adını giriniz: ", i+1);
            //    sınıf[i] = Console.ReadLine();
            //}
            //for(int i=0; i<sınıf.Length; i++)
            //{
            //    Console.WriteLine(sınıf[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 17

            //int toplamrakam = 0;
            //string metin;
            //Console.WriteLine(" Bir sayı giriniz: ");
            //metin = Console.ReadLine();
            //for(int i=0; i<metin.Length; i++)
            //{
            //    toplamrakam += Convert.ToInt32(metin[i].ToString());
            //}
            //Console.WriteLine(" Girdiğiniz sayının rakamları toplamı: {0} ", toplamrakam);
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 18

            //string metin;
            //metin = Console.ReadLine().ToLower();
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    Console.Clear();
            //    for (int j = 0; j < metin.Length; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(metin[j].ToString().ToUpper());
            //        }
            //        else
            //        {
            //            Console.Write(metin[j].ToString().ToLower());
            //        }
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region DO WHİLE ÖRNEK
            //string kullaniciadi1 = "Osman";
            //string sifre1 = "Erdem";
            //string kullaniciadi;
            //string sifre;
            //int deneme = 0;
            //do
            //{
            //    Console.WriteLine(" Kullanıcı adını giriniz: ");
            //    kullaniciadi = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(" Şifre giriniz: ");
            //    sifre = Convert.ToString(Console.ReadLine());
            //    deneme++;
            //    if (deneme ==3)
            //    {
            //        Console.WriteLine(" Hesabınız kitlenmiştir. Lütfen tekrar deneyiniz. ");

            //    }

            //} while (kullaniciadi1 != kullaniciadi && sifre1 != sifre);
            //Console.WriteLine(" Giriş Başarılı ");
            //Console.ReadLine();
            #endregion

            #region METOD ÖRNEK 1

            //static void Main(string[] args)
            //{
            //    Console.WriteLine(" Birinci sayıyı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" İkinci sayıyı giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Topla(sayi1, sayi2));
            //}
            //static int Topla(int sayi1, int sayi2)
            //{
            //    return sayi1 + sayi2;
            //}
            #endregion

            #region METOD ÖRNEK 2 

            //static void Main(string[] args)
            //{
            //    Console.WriteLine(" Birinci sayıyı giriniz: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" İkinci sayıyı giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Ortalama(sayi1, sayi2));
            //    Console.ReadLine();
            //}

            //static float Ortalama(int sayi1, int sayi2)
            //{
            //    int toplam = 0;
            //    int gecici;
            //    int sayac = 0;
            //    if (sayi1 > sayi2)
            //    {
            //        gecici = sayi1;
            //        sayi1 = sayi2;
            //        sayi2 = gecici;
            //    }
            //    for (int i = sayi1; i < sayi2; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            sayac++;
            //            toplam += i;
            //        }
            //    }
            //    return (float)toplam / sayac;
            //}

            #endregion

            #region DİZİ ÖRNEK 19

            //int[,] dizi = new int[10, 10];
            //Random rnd = new Random();
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    for (int j = 0; j < dizi.Length; j++)
            //    {
            //        dizi[i, j] = rnd.Next(10);
            //        Console.Write(dizi[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int m = 0; m < 10; m++)
            //{
            //    int satırtoplam = 0;
            //    int sutuntoplam = 0;
            //    for (int n = 0; n < 10; n++)
            //    {
            //        satırtoplam += dizi[m, n];
            //        sutuntoplam += dizi[n, m];
            //    }
            //    Console.WriteLine(" {0}. satırın toplamı: {1} ///////// {2}. sütunun toplamı: {3}", m + 1, satırtoplam, m+ 1, sutuntoplam);
            //}
            //Console.ReadLine();
            #endregion

            #region DİZİ ÖRNEK 20
            //int[,] dizi = new int[2, 2];
            //Console.WriteLine(" Matrisin 1. satır 1. sütundaki elemanını giriniz: ");
            //double eleman1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Matrisin 1. satır 2. sütundaki elemanını giriniz: ");
            //double eleman2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Matrisin 2. satır 1. sütundaki elemanını giriniz: ");
            //double eleman3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Matrisin 2. satır 2. sütundaki elemanını giriniz: ");
            //double eleman4 = Convert.ToInt32(Console.ReadLine());
            //double det = 0;
            //if (eleman1 * eleman4 - (eleman2 * eleman3) == 0)
            //{
            //    Console.WriteLine(" Matrisiniz singüler matristir. Tersi yoktur. ");
            //}
            //else
            //{
            //    det = eleman1 * eleman4 - (eleman2 * eleman3);
            //    Console.WriteLine(" Matrisinizin determinantı: {0} ", det);

            //    Console.WriteLine(" Matrisiniz tersi vardır ve şudur: ");

            //    double[,] c = new double[2, 2];
            //    c[0, 0] = eleman4/det;
            //    c[0, 1] = -eleman3/det;
            //    c[1, 0] = -eleman2/det;
            //    c[1, 1] = eleman1/det;

            //   for(int i=0; i<2; i++)
            //    {
            //        for(int j=0; j<2; j++)
            //        {
            //            Console.Write(c[i, j] + "  ");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region ARRAY LİST ÖRNEK 2
            //Console.WriteLine(" Çevirmek istediğiniz cümleyi giriniz: ");
            //string cümle = Convert.ToString(Console.ReadLine());
            //char[] harf = cümle.ToCharArray();
            //Array.Reverse(harf);
            //for(int i=0; i<cümle.Length; i++)
            //{
            //    Console.Write(harf[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region ARRAY LİST ÖRNEK 3

            //ArrayList liste = new ArrayList();
            //liste.Add(35);
            //liste.Add("osman");
            //liste.Add('a');
            //liste.Remove(35);
            //liste.Clear();
            //Console.WriteLine(liste[0]);




            #endregion

            #region ARRAY LİST ÖRNEK 2 (TEKRAR)
            //Console.WriteLine(" Çevirmek istediğiniz cümleyi giriniz: ");
            //string cumle = Convert.ToString(Console.ReadLine());
            //char[] harf = cumle.ToCharArray();
            //Array.Reverse(harf);
            //for(int i=0;  i<cumle.Length; i++)
            //{
            //    Console.Write(harf[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region DİZİ ÖRNEK 21
            //Console.WriteLine(" Dizinizin kaç elemanlı olmasını istediğinizi giriniz: ");
            //int gelen = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[gelen];
            //int sayi;
            //int sayac = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(" Dizinin {0}. elemanını giriniz: ", i + 1);
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (dizi[sayi] % 2 == 0)
            //    {
            //        sayac++;
            //    }

            //    foreach (int a in dizi)
            //    {
            //        Console.WriteLine(" Dizinizdeki elemanlar: {0} ", a);
            //    }
            //}
            //Console.WriteLine(" Dizinizdeki çift sayı adedi: {0} ", sayac);
            //Console.ReadLine();
            #endregion

            #region METOTLAR ÖRNEK 1 

            //int Topla(int a, int b)
            //{
            //    return a + b;
            //}

            //static void Main(string[] args)
            //{
            //    Metotlar nesne = new Metotlar();
            //    int malfatmanur = nesne.Topla(52, 31);
            //    Console.WriteLine(malfatmanur);
            //    Console.ReadLine();


            //}
            #endregion

            #region METOTLAR ÖRNEK 2 

            //static int Topla(int a, int b) //eğer burada static kullanırsak nesne oluşturmamıza gerek kalmaz.
            //{
            //    return a + b;
            //}

            //static void Main(string[] args)
            //{
            //    int a = Topla(8, 78);
            //    Console.WriteLine(a);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 3
            //    public static int Topla(int a, int b)
            //    {
            //        return a + b;
            //    }
            //        class Metotlar2
            //{
            //    static void Main()
            //    {
            //        int a = Metotlar.Topla(78, 42);
            //        Console.WriteLine(a);
            //        Console.ReadLine();
            //    }
            //}
            #endregion

            #region METOTLAR ÖRNEK 4

            //static void Yaz(int[] dizi)
            //{
            //    foreach (object i in dizi)
            //        Console.WriteLine(i);
            //}

            //static void Main()
            //{
            //    int[] dizi = { 42, 58, 76, 98, 12, 23 };
            //    Yaz(dizi);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 5 

            //static void DiziYaz(int[]dizi)
            //{
            //    foreach (int i in dizi)
            //        Console.WriteLine(i);
            //}

            //static void Main(string[] args)
            //{
            //    int[] dizi1 = { 45, 85, 72, 96, 35, 1 };
            //    int[] dizi2 = { 78, 10, 23, 45, 336, 3 };
            //    Console.WriteLine(" İlk diziniz: ");
            //    DiziYaz(dizi1);
            //    Console.WriteLine(" İkinci diziniz: ");
            //    DiziYaz(dizi2);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 6

            //static void Degistir( int sayi)
            //{
            //    sayi = 10;
            //}
            //static void Yaz(int sayi)
            //{
            //    Console.WriteLine(sayi);
            //}

            //static void Main(string[] args)
            //{
            //    int sayi = 1;
            //    Degistir(sayi);
            //    Yaz(sayi);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 7

            //static void Degistir(int[] dizi)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        dizi[i] = 10;
            //    }
            //}

            //static void Yaz(Array dizi)
            //{
            //    foreach (int a in dizi)
            //        Console.WriteLine(a);
            //}

            //static void Main(string[] args)
            //{
            //    int[] dizi = { 2, 6, 8, 7, 36 };
            //    Degistir(dizi);
            //    Yaz(dizi);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 8

            //static void DegerTipi(out int sayi)
            //{
            //    sayi = 11;
            //}

            //static void Main(string[] args)
            //{
            //    int sayi;
            //    DegerTipi( out sayi);
            //    Console.WriteLine(sayi);
            //    Console.ReadLine();

            //}
            #endregion

            #region METOTLAR ÖRNEK 9

            //static int İslem(string a, params int[] sayilar)
            //{
            //    if (a == "carp")
            //    {
            //        if (sayilar.Length == 0)
            //            return 1;
            //        int carpim = 1;
            //        foreach (int i in sayilar)
            //            carpim *= i;
            //        return carpim;
            //    }
            //    else if (a == "topla")
            //    {
            //        if (sayilar.Length == 0)
            //            return 1;
            //        int toplam = 0;
            //        foreach (int i in sayilar)
            //            toplam += i;
            //        return toplam;
            //    }
            //    else return 0;
            //}

            //static void Main(string[] args)
            //{
            //    Console.WriteLine(İslem("topla", 65, 74, 10, 23, 41));
            //    Console.WriteLine(İslem("carp", 7, 5, 8, 10));
            //    Console.ReadLine();

            //}

            #endregion

            #region METOTLAR ÖRNEK 10

            //static int Toplam(params int[] sayilar)
            //{
            //    if (sayilar.Length == 0)
            //        return 0;
            //    int toplam = 0;
            //    foreach (int i in sayilar)
            //        toplam += i;
            //    return toplam;

            //}

            //static void Main(string[] args)
            //{
            //    Console.WriteLine(Toplam());
            //    Console.WriteLine(Toplam(5));
            //    Console.WriteLine(Toplam(5, 10));
            //    Console.WriteLine(Toplam(5, 10, 15));
            //    Console.ReadLine();
            //}

            #endregion

            #region METOTLAR ÖRNEK 11

            //static void Metot1(int a, int b)
            //{
            //    Console.WriteLine(" Birinci metot çağırıldı. ");
            //}

            //static void Metot1(float a, float b)
            //{
            //    Console.WriteLine(" İkinci metot çağırıldı. ");
            //}

            //static void Metot1(string a, string b)
            //{
            //    Console.WriteLine(" Üçüncü metot çağırıldı");
            //}

            //static void Main(string[] args)
            //{
            //    Metot1("osman", "memet");
            //    Metot1(10.5f, 12.3f);
            //    Metot1(14, 18);
            //    Console.ReadLine();
            //}
            #endregion

            #region METOTLAR ÖRNEK 12

            //    static void Main(string[] args)
            //    {
            //        int bakiye = 500;
            //        Console.WriteLine(" Şifreyi giriniz: ");
            //        int sifre = Convert.ToInt32(Console.ReadLine());

            //        if (SifreKontrol(sifre) == false)

            //            for (int i = 0; i < 3; i++)
            //            {
            //                Console.WriteLine(" Hatalı şifre tekrar deneyiniz: ");
            //                sifre = Convert.ToInt32(Console.ReadLine());
            //                if (i == 2 && SifreKontrol(sifre) == false)
            //                {
            //                    Console.WriteLine(" Kart bloke olmuştur. ");
            //                    Environment.Exit(0);
            //                }
            //                if (SifreKontrol(sifre) == true)

            //                    break;

            //            }

            //        Console.Clear();
            //        while (SifreKontrol(sifre) == true)
            //        {
            //            Console.WriteLine("1- Para Yatır ");
            //            Console.WriteLine("2- Para Çek ");
            //            Console.WriteLine("3- Bakiye Sorgula ");
            //            Console.WriteLine("4- Çıkış ");
            //            int secim = Convert.ToInt32(Console.ReadLine());
            //            Console.Clear();
            //            switch (secim)
            //            {
            //                case 1:
            //                    bakiye = ParaYatir(bakiye);
            //                    Console.WriteLine(" İşlem tamam ");
            //                    Console.Clear();
            //                    break;

            //                case 2:
            //                    bakiye = ParaCek(bakiye);
            //                    Console.WriteLine(" İşlem tamam ");
            //                    Console.Clear();
            //                    break;

            //                case 3:
            //                    Sorgula(bakiye);
            //                    Console.WriteLine(" Ana menüye dönmek için bir tuşa basın. ");
            //                    Console.ReadKey();
            //                    Console.Clear();
            //                    break;

            //                case 4:
            //                    Console.WriteLine(" Kartı al. ");
            //                    Environment.Exit(0);
            //                    Console.Clear();
            //                    break;
            //            }
            //        }
            //        Console.ReadLine();

            //    }

            //    static bool SifreKontrol(int sifre)
            //    {
            //        if (sifre == 1234)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }

            //    static int ParaCek(int bakiye)
            //    {
            //        Console.WriteLine(" Çekmek istediğiniz miktarı giriniz: ");
            //        return bakiye - Convert.ToInt32(Console.ReadLine());
            //    }

            //    static int ParaYatir(int bakiye)
            //    {
            //        Console.WriteLine(" Yatırmak istediğiniz miktarı giriniz: ");
            //        return bakiye + Convert.ToInt32(Console.ReadLine());
            //    }

            //    static void Sorgula(int bakiye)
            //    {
            //        Console.WriteLine(" Bakiyeniz: " + bakiye);
            //    }
            //}

            #endregion


        
    } 
}
