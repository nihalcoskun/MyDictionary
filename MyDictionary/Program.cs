using System;

namespace MyDictionary
{
    class Program
    {
        /*Dictionary sınıfı bir koleksiyon sınıfıdır.İçinde belirlediğimiz typeda bir 'key' ve ona karşılık gelen 'değeri' saklar.
        Arraylerden farklı olarak değişken boyutludur.Dilediğimiz gibi listeleme yapıp, eleman ekleyip-çıkartma gerçekleştirebiliriz.*/
        static void Main(string[] args)
        {
            MyDictionary <int , string> catalog = new MyDictionary<int , string>();

            catalog.Add(150119791, "IKEA Dolap");
            catalog.Add(886549372, "PANAMA Nevresim");
            catalog.Add(624753188, "FLASHLIGHT Masa Lambası");
            catalog.Add(426753147, "DELUXE Koltuk Takımı");


            Console.WriteLine("Toplam ürün adedi: " + catalog.numOfProducts);


        }
       
    }

    
}
