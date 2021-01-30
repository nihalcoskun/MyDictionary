using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] idNumbers;
        T2[] products;

        T1[] TempId;
        T2[] TempProduct;

        public MyDictionary()
        {
         idNumbers = new T1[0];
         products = new T2[0];
    }
        public void Add(T1 key, T2 value)
        {
            TempId = idNumbers;
            TempProduct = products;

            idNumbers = new T1[idNumbers.Length + 1];
            products = new T2[products.Length + 1];

            for (int i = 0; i < TempId.Length; i++)
            {
                idNumbers[i] = TempId[i];
                products[i] = TempProduct[i];
            }

            idNumbers[idNumbers.Length - 1] = key;
            products[products.Length - 1] = value;
            Console.WriteLine("Ürün Adı: " + value + " ID:" + key );
            Console.WriteLine("----------------------------------");
           
        }

        public int numOfProducts
        {
            get { return products.Length; }
        }
        




    }
}
