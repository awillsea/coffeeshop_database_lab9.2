using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using CoffeeShop_Product_List.Models;


namespace CoffeeShop_Product_List.Controllers
{
    public class LoyalClientController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=abc123!");
            IEnumerable<LoyalClient> cli = db.GetAll<LoyalClient>();

            return View(cli);
        }
        public IActionResult Detail(int id)
        {
            string ID = id.ToString();
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=abc123!");
            LoyalClient LC = db.Get<LoyalClient>(id);

            List<Product> rand = db.Query<Product>($"select * from product").ToList();
            ViewData["Client"]= rand;

            //return Content(ID);
            return View(LC);
        }
    }
}
