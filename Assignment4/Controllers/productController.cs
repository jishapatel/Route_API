using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment4.Controllers
{
    [RoutePrefix("api/Product")]
    public class productController : ApiController
    {
        public class Product
        {
            public String p_id;
            public String p_name;
            public String p_desc;

        }

        static List<Product> products = new List<Product>();
        [Route("ShowAll")]
        public List<Product> GetAll()
        {
            return products;
        }
        [Route("InsertProduct")]
        public String PostProduct(Product p)
        {
            products.Add(p);
            return "Product Added Successfully";
        }
        [Route("UpdateProduct")]
        public String PatchProduct(Product p, int index)
        {
            products[index] = p;
            return "Product Updated Successfully";
        }
        [Route("DeleteProduct")]
        public String DeleteProduct(int index)
        {
            products.RemoveAt(index);
            return "Product Deleted Successfully";
        }
    }
}
