using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoeStore.Models;

namespace ShoeStore.Repository
{
    public class InMemoryShoesRepository : IShoesRepository
    {
        private readonly List<Shoe> store = new List<Shoe>() 
        { 
            new Shoe()
            {
                Id = 1,
                Brand = "Nike",
                Name = "Air Force",
                Size = 10,
                Price = 99.99m,
                Color = "White",
                ShoeType = ShoeType.Casual,
                UserType = UserType.Men,
                CreatedOn = DateTime.Now,
                BarCode = Guid.NewGuid()
            },
            new Shoe()
            {
                Id = 2,
                Brand = "Adidas",
                Name = "Sambas",
                Size = 10,
                Price = 69.99m,
                Color = "Black/White",
                ShoeType = ShoeType.Training,
                UserType = UserType.Men,
                CreatedOn = DateTime.Now,
                BarCode = Guid.NewGuid()
            },
            new Shoe()
            {
                Id = 3,
                Brand = "Pumas",
                Name = "Limited Edition",
                Size = 10,
                Price = 89.99m,
                Color = "Red/White",
                ShoeType = ShoeType.Training,
                UserType = UserType.Men,
                CreatedOn = DateTime.Now,
                BarCode = Guid.NewGuid()
            }
        };
        public void CreateShoe(Shoe shoe)
        {
            store.Add(shoe);
        }

        public void DeleteShoeById(int id)
        {
            var index = store.FindIndex(shoe => shoe.Id == id);
            store.RemoveAt(index);
        }

        public Shoe GetShoeById(int id)
        {
            return store.Where(book => book.Id == id).SingleOrDefault();
        }

        public IEnumerable<Shoe> GetShoes()
        {
            return store;
        }

        public void UpdateShoe(Shoe shoe)
        {
            var index = store.FindIndex(existingShoe => existingShoe.Id == shoe.Id);
            store.RemoveAt(index);
        }
    }
}
