using AssetManagement.Models.Items;
using AssetManagement.Models.Items.Data;
using AssetManagement.Models.Items.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }



        [HttpGet("list")]
        public ActionResult<IEnumerable<ItemDto>> GetAllItems()
        {
            var model = _itemRepository.GetItemsList();
            if (model != null)
            {
                return Json(model);
            }
            else
            {
                return NotFound();
            }
            //throw new NotImplementedException();
        }

    }
}
