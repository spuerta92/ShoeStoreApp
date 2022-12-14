using ShoeStore.Dtos;
using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore
{
    public static class Extensions
    {
        public static ShoeDto AsDto(this Shoe shoe)
        {
            return new ShoeDto()
            {
                Id = shoe.Id,
                Brand = shoe.Brand,
                Name = shoe.Name,
                Size = shoe.Size,
                Price = shoe.Price,
                Color = shoe.Color,
                ShoeType = shoe.ShoeType,
                UserType = shoe.UserType,
                CreatedOn = shoe.CreatedOn,
                BarCode = shoe.BarCode
            };
        } 
    }
}
