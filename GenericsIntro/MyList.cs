using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic class ile bizim belirttiğimiz bir tipte class oluşturacağımızı
    //ve bununla çalışağımızı belirtiyoz.
    class MyList<T> // T demek kullanıcıdan o anki veri tipinde değişken isteme
    {
        T[] items;
        
        //constractor 
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //items referans değerini attık
            items = new T[items.Length + 1]; // yeni bir items array oluşturduk bu 0 elemalı oluşur DİKKAT ET ve biz 1 eleman ekleme yaptık.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];// referans değerleri tekrardan items içine doldurduk
            }

            items[items.Length - 1] = item; // artık sonuncu elamını items arrayının sonuncu elmanına ekleyebilriz.
        }

        public int  Lentgh
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
