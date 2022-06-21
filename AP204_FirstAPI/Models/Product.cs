using System.ComponentModel.DataAnnotations.Schema;

namespace AP204_FirstAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SoldPrice { get; set; }
        public decimal CostPrice { get; set; }
        public bool DisplayStatus { get; set; }
    }
}
