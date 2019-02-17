using FJFMarketing.Models.Entities;
using FJFMarketing.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FJFMarketing.Controllers
{
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Item item)
        {
            if (item == null)
                return BadRequest();

            this._itemService.AddItem(item);

            return Ok(item);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _itemService.GetAllItem();

            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var item = this._itemService.GetItemById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Item item, string id)
        {
            if (item == null)
                return BadRequest();

            this._itemService.UpdateItem(id, item);

            return NoContent();
        }
    }
}
