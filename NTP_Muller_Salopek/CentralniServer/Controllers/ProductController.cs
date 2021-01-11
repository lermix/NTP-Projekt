using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniServer.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return Get();
        }

        [HttpGet]
        public string Delete(int id)
        {
            if (id <= 0)
                return "N";
            bool success = Data.DBManager.DeleteProduct(id);
            return success ? "Y" : "N";
        }

        [HttpPost]
        public string Add(string name, string buttonName, float? price)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(buttonName) ||
                !price.HasValue)
            {
                return "N_Parameters_name_buttonName_price";
            }

            if (Data.DBManager.AddProduct(new { name, buttonName, price= price.Value }))
                return "Y";
            else return "N_Error";
        }

        // /Users/Get
        [HttpGet]
        public string Get()
        {
            var products = Data.DBManager.FetchProducts();
            string res = products != null ? JsonConvert.SerializeObject(products) : "";
            return res;
        }
    }
}
