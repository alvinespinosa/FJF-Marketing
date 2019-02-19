using FJFMarketing.Models.Entities;
using FJFMarketing.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FJFMarketing.Controllers
{
    [Route("Payables")]
    public class PayableController: ControllerBase
    {
        private IPayableService _payableService;

        public PayableController(IPayableService payableService)
        {
            _payableService = payableService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Payable payable)
        {
            if (payable == null)
                return BadRequest();

            this._payableService.AddPayable(payable);

            return Ok(payable);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var payable = this._payableService.GetPayableById(id);

            if (payable == null)
            {
                return NotFound();
            }

            return Ok(payable);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var payables = _payableService.GetAllPayable();

            return Ok(payables);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Payable payable, string id)
        {
            if (payable == null)
                return BadRequest();

            this._payableService.UpdatePayable(id, payable);

            return NoContent();
        }
    }
}
