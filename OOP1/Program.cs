﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); 
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id=2,CategoryId=5,
                UnitInStock=5,ProductName="Kalem",UnitPrice=35};

           //PascalCase    //camelCase
           //case sensitive
           //Stack                                //heap
            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//Kamera
            



            

            Console.ReadLine();

            //int,double,bool....Değer Tip
            //array,class,interface....Referans Tip
            //ref out
            

        }
    }
}
