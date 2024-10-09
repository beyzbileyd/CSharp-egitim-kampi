using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:"+applePrice + " Tl");
            //Console.WriteLine("---- Portakal Birim Fiyatı:"+orangePrice + " Tl");
            //Console.WriteLine("---- Çilek Birim Fiyatı:"+strawberryPrice + " Tl");
            //Console.WriteLine("---- Patates Birim Fiyatı:"+potatoPrice + " Tl");
            //Console.WriteLine("---- Domates Birim Fiyatı:"+tomatoPrice + " Tl");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.65;
            //strawberryGram = 0.75;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyatı:"+ applePrice+"-Gramaj: "+appleGram+ "-Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyatı:"+ orangePrice+"-Gramaj: "+orangeGram+ "-Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyatı:"+ strawberryPrice+"-Gramaj: "+strawberryGram+ "-Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyatı:"+ potatoPrice+"-Gramaj: "+potatoGram+ "-Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyatı:"+ tomatoPrice+"-Gramaj: "+tomatoGram+ "-Toplam Tutar: "+tomatoTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //double shopppingTotalPrice;

            //shopppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutar: "+shopppingTotalPrice+" TL");




            #endregion

            #region Char Değişkenler
            //Karakter türünde değişkenler oluşturur.

            //char symbol;
            //symbol= 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdenty;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdenty = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdenty + " - Yolcu Ad Soyad: "+passengerName + " " + passengerSurname+ " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("Toplam Ödemeniz Gereken Tutar: "+ totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //ondalıklı olarak sınav sonucu hesaplama
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giirniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.Write("Sınav Ortalamanız: "+result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;

            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.Write("Seçtiğiniz Cinsiyet: "+gender);

            #endregion

            Console.ReadLine();
        }
    }
}
