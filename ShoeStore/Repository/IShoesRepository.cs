using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Repository
{
    public interface IShoesRepository
    {
        IEnumerable<Shoe> GetShoes();
        Shoe GetShoeById(int Id);
        void CreateShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoeById(int Id);
    }
}
