using System;

namespace Kodlama.io_2.Gün_Ödev6_E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = "Dizüstü Bilgisayar";
            product1.name = "Asus Laptop";
            product1.UnitPrice = 2500;
            product1.Description = "i7 işlemcili Laptop";
            product1.Stock = 25;


            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = "Akıllı Telefon";
            product2.name = "iPhone 12 Pro Max";
            product2.UnitPrice = 15000;
            product2.Description = "A14 Bionic Çip";
            product2.Stock = 18;


            Product product3 = new Product();
            product3.Id = 3;
            product3.CategoryId = "TWS kulaklık";
            product3.name = "AirPods Pro";
            product3.UnitPrice = 1900;
            product3.Description = "24 saate kadar pil ömrü";
            product3.Stock = 86;



            Product product4 = new Product();
            product4.Id = 4;
            product4.CategoryId = "Wireless Keyboard";
            product4.name = "Dell KMK 636 kablosuz klavye";
            product4.UnitPrice = 250;
            product4.Description = "Kablosuz klavye - mouse set";
            product4.Stock = 75;

            //new array to products
            Product[] products = new Product[] { product1, product2, product3, product4 };

            //Ürünlerin Lİstelenmesi ve ekrana yazdırılması

            
            Console.WriteLine("*********************ÜRÜN LİSTESİ********************\n\n");
        

            foreach (var product in products)
            {
                
                Console.WriteLine("Ürün Id : " + product.Id);
                Console.WriteLine("Ürün Kategorisi : " + product.CategoryId);
                Console.WriteLine("Ürün Adı : " + product.name);
                Console.WriteLine("Ürün Fiyatı: " + product.UnitPrice);
                Console.WriteLine("Ürün Açıklaması : " + product.Description);
                Console.WriteLine("Ürün Stok Adedi : " + product.Stock);
                Console.WriteLine("*****************************************************\n");
            }

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);
            sepetManager.Update(product1);
            sepetManager.Delete(product1);
            Console.WriteLine("-----------------------------------------------------------\n");

            sepetManager.Add2(product2);
            sepetManager.Update(product2);
            sepetManager.Delete(product2);
            Console.WriteLine("-----------------------------------------------------------\n");

            sepetManager.Add(product3);
            sepetManager.Update(product3);
            sepetManager.Delete(product3);
            Console.WriteLine("-----------------------------------------------------------\n");


            sepetManager.Add2(product4);
            sepetManager.Update(product4);
            sepetManager.Delete(product4);
            Console.WriteLine("-----------------------------------------------------------\n");








        }


    }
}
