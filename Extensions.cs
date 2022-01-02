using Spliwise.Dtos;
using Spliwise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spliwise
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto()
            {
                Id = item.Id,
                CreatedDate = item.CreatedDate,
                Name = item.Name,
                Price = item.Price
            };
        }
    }
}
