using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_2.Gün_Ödev6_E_Ticaret
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün sepete eklendi.");
        }

        public void Add2(Product product)
        {
            Console.WriteLine(product.name + " " + "başarıyla sepete eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.name + " " +  "isimli ürün sepetten silindi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Sepet güncellendi.");
        }

    }
}
