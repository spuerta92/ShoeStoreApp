using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Tests
{
    public class Api : BaseApi
    {
        private readonly string resource_shoes = "/shoes";
        public List<Shoe> GetShoes()
        {
            return Get<List<Shoe>>(resource_shoes);
        }
    }
}
