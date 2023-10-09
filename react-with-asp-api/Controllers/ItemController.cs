using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using react_with_asp_api.Models;

namespace react_with_asp_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new List<ItemModel>
        {
            new ItemModel { Name = "Item 1", Type = 1 },
            new ItemModel { Name = "Item 2", Type = 2 },
            new ItemModel { Name = "Item 3", Type = 2 },
            new ItemModel { Name = "Item 4", Type = 3 },
            new ItemModel { Name = "Item 5", Type = 3 },
            new ItemModel { Name = "Item 6", Type = 3 }
        };

        [HttpGet("{type:int}")]
        public ItemModel[] GetItemModels(int type)
        {
            ItemModel[] items = Items.Where(item => item.Type == type).ToArray();
            return items;
        }

    }
}
