﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int , string> ogrenci = new MyDictionary<int,string>();
            ogrenci.Add(1, "Orhan");
            ogrenci.Add(2, "Muhammet");
            Console.WriteLine(ogrenci.Length);
        }
    }
}
