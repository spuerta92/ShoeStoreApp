using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public ushort Size { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public ShoeType ShoeType { get; set; }
        public UserType UserType { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid BarCode { get; set; }
    }
}
