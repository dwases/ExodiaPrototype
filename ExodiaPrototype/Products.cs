using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Products
    {
        public List<Product> products = new List<Product>();

        //choice : 1 - dodanie nowego produktu, 2 - usuniecie danego produktu, 3 - wyczyszczenie listy
        public void EditProductList(int choice, Product produktDocelowy)
        {
            if (choice == 1)
                products.Add(produktDocelowy);
            else if (choice == 2)
                products.Remove(produktDocelowy);
            else
                products.Clear();
        }
    }
}
