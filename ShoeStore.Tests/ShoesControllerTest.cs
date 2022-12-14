using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Tests
{
    public class ShoesControllerTest
    {
        private Api api;
        
        [SetUp]
        public void SetUp()
        {
            api = new Api();
        }

        [Test]
        public void GetShoes_RetriveAllShoes_ReturnIsSuccessful()
        {
            var shoes = api.GetShoes();
            Assert.NotNull(shoes);
        }
    }
}
