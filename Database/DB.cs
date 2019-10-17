using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DB
    {
        public static DemoEntities myDb = new DemoEntities();

        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }

        public static IEnumerable<Customer> GetCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static IEnumerable<Sale> GetSalesList()
        {
            return myDb.Sales.ToList();
        }
       

        public static String updateCustomer(int id)
        {
            String fname = "NEW";
            String lname = "CUS";
            Customer cus = myDb.Customers.Find(id);
            cus.CustomerFirstName = fname;
            cus.CustomerLastName = lname;
            return ("Customer: " + id + " has been updated" + " First name: " + cus.CustomerFirstName + " Last name:" + cus.CustomerLastName);

        }

        public static String deleteProduct(int id)
        {
            Product p = myDb.Products.Find(id);
            myDb.Products.Remove(p);
            myDb.SaveChanges();

            return ("Product with id: "+id+" has been deleted");
        }
    }
}
