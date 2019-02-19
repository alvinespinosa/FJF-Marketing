using FJFMarketing.Models.Entities;
using FJFMarketing.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FJFMarketing.Controllers
{
    [Route("Purchases")]
    public class PurchaseController : ControllerBase
    {
        private IPurchaseServicecs _purchaseService;

        public PurchaseController(IPurchaseServicecs purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Purchase purchase)
        {
            if (purchase == null)
                return BadRequest();

            this._purchaseService.AddPurchase(purchase);

            return Ok(purchase);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var purchase = this._purchaseService.GetPurchaseById(id);

            if (purchase == null)
            {
                return NotFound();
            }

            return Ok(purchase);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var purchases = _purchaseService.GetAllPurchase();

            return Ok(purchases);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Purchase purchase, string id)
        {
            if (purchase == null)
                return BadRequest();

            this._purchaseService.UpdatePurchase(id, purchase);

            return NoContent();
        }
    }
}
