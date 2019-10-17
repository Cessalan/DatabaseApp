using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            


            // display Sales
            IEnumerable<Sale> sales = DB.GetSalesList();
            foreach (Sale s in sales) {

                Console.WriteLine("Sales ID:  "+s.SaleId +" Customer Name: "+ 
                    s.Customer.CustomerFirstName +" Product Description: "+ s.Product.ProductDescription);
            }

            String newCustomer = DB.updateCustomer(2);
            Console.WriteLine(newCustomer);

            String deletedProduct = DB.deleteProduct(1);
            Console.WriteLine(deletedProduct);

        }
    }
}
