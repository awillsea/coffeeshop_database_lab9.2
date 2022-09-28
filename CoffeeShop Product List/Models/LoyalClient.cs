using Dapper.Contrib.Extensions;

namespace CoffeeShop_Product_List.Models
{
    [Table("loyalclient")]
    public class LoyalClient
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int points { get; set; }

    }
}
