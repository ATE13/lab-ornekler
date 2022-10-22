using System;

namespace LabUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uygulama 1 (operatörlerin işlem önceliği)
            {
                //    Console.WriteLine(48 / 6 / 4);                  //2
                //    Console.WriteLine(24 / 3 * 2);                  //16
                //    Console.WriteLine(4 + 5 - 1 + 4);               //12
                //    Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);     //25
                //    Console.WriteLine((5 - 1) * 2 - 1 + 49 / 2);    //31
            }

            //Uygulama 2 (mantıksal ifadelerin doğru ya da yanlış olduğunu yazdırma)
            {
                //int x = 20;
                //int y = 13;
                //int z = 42;
                //if (23 == 55 && 76 > 45 && 5 < 12)
                //{
                //    Console.WriteLine("1. if çalıştı");      //çalışmaz
                //}
                //if (23 >= 23 && 45 != 18)
                //{
                //    Console.WriteLine("2. if çalıştı");     //çalışır
                //}
                //if (x > y && z == y && z < x)
                //{
                //    Console.WriteLine("3. if çalıştı");     //çalışmaz
                //}
                //if (z > x && y < x)
                //{
                //    Console.WriteLine("4. if çalıştı");     //çalışır
                //}
                //if(x != z || y <= z)
                //{
                //    Console.WriteLine("5. if çalıştı");     //çalışır
                //}
            }

            //Uygulama 3 (girilen iki sayının birbirine tam bölünüp bölünmediğini bulma)
            {
                //Console.WriteLine("İlk sayıyı girin : ");
                //int sayi1 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("İkinci sayıyı giriniz : ");
                //int sayi2 = Convert.ToInt32(Console.ReadLine());

                //if (sayi1 % sayi2 == 0 || sayi2 % sayi1 == 0)
                //{
                //    Console.WriteLine("Girilen sayılar tam bölünüyor");
                //}
                //else {
                //    Console.WriteLine("Sayılar tam bölünmüyor"); 
                //}
            }

            //Uygulama 4 (girilen tarihin ayını yazdımak)
            {
                //Console.WriteLine("Gün'ü girin : ");
                //int gün = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Ay'ı (1/12) girin : ");
                //int ay = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Yıl'ı girin : ");
                //int yil = Convert.ToInt32(Console.ReadLine());

                //switch (ay)
                //{
                //    case 1:
                //        Console.WriteLine("Ocak Ayındasınız");
                //        break;
                //    case 2:
                //        Console.WriteLine("Şubat Ayındasınız");
                //        break;
                //    case 3:
                //        Console.WriteLine("Mart Ayındasınız");
                //        break;
                //    case 4:
                //        Console.WriteLine("Nisan Ayındasınız");
                //        break;
                //    case 5:
                //        Console.WriteLine("Mayıs Ayındasınız");
                //        break;
                //    case 6:
                //        Console.WriteLine("Haziran Ayındasınız");
                //        break;
                //    case 7:
                //        Console.WriteLine("Temmuz Ayındasınız");
                //        break;
                //    case 8:
                //        Console.WriteLine("Ağustos Ayındasınız");
                //        break;
                //    case 9:
                //        Console.WriteLine("Eylül Ayındasınız");
                //        break;
                //    case 10:
                //        Console.WriteLine("Ekim Ayındasınız");
                //        break;
                //    case 11:
                //        Console.WriteLine("Kasım Ayındasınız");
                //        break;
                //    case 12:
                //        Console.WriteLine("Aralık Ayındasınız");
                //        break;

                //    default: Console.WriteLine("Yanlış tarih girdiniz");
                //        break;

            }

            //Uygulama 5 (ikinci dereceden girilen denklemin köklerini bulma)
            {
                //Console.WriteLine("Ax² + Bx + C = 0 Denkleminde");
                //Console.WriteLine("A değerini girin : ");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("B değerini girin : ");
                //int b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("C değerini girin : ");
                //int c = Convert.ToInt32(Console.ReadLine());
                //double delta = (b * b) - (4 * a * c);

                //if (delta > 0)
                //{
                //    double x1 = ((-b - Math.Sqrt(delta)) / (2 * a));
                //    double x2 = ((-b + Math.Sqrt(delta)) / (2 * a));
                //    Console.WriteLine("Denklemin iki kökü vardır ");
                //    Console.WriteLine("Birinci kök = {0} İkinci kök = {1}", x1, x2);
                //}
                //else if (delta == 0)
                //{
                //    double x = -b / 2 * a;
                //    Console.WriteLine("Denkelmin bir kökü vardır x = {0}", x);
                //}
                //else
                //{
                //    Console.WriteLine("Delta sıfırdan küçük kökler reel değil");
                //}
            }

            //Uygulama 6 (Girilen dereceyi radyan ve gradyan değerine çevirmek)
            {
            //    Console.WriteLine("Radyan ve Gradyan'a çevrilecek dereceyi giriniz : ");
            //    double derece = Convert.ToDouble(Console.ReadLine());
    


            //    double radyan = derece * Math.PI / 180;
            //    double gradyan = derece / 400 * 360;
            //    Console.WriteLine("{0} Derece = {1} Radyan = {2} Gradyan", derece, radyan, gradyan);
            }

            Console.ReadKey();
        }
    }
}