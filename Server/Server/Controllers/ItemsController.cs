using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet("page/{pageNumber}/amount/{count}")]
        public IEnumerable<Item> Get(int pageNumber,int count)
        {
            var list = Faker.Extensions.EnumerableExtensions.Times(1000, a => new Item()
            {
                Title = Faker.Name.First(),
                Type = Faker.Name.Last(),
                Description = Faker.Address.SecondaryAddress(),
                Id = Faker.RandomNumber.Next(),
                Text = Faker.Country.Name(),
                Tags = new List<string>() {Faker.Name.First(), Faker.Name.First(), Faker.Name.First()},
                Img = $"img{Faker.RandomNumber.Next(1,3)}.jpg",
                ImgLarge = $"img{Faker.RandomNumber.Next(1,3)}.jpg"
            });

            return list.Skip((pageNumber-1) * count).Take(count);
        }
    }
}
