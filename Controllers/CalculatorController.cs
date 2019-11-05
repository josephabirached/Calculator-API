using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorAPI.Models;
using CalculatorAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("ca/")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorServices _services;

        public CalculatorController(ICalculatorServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("SumCalculatorItems")]
        public ActionResult<CalculatorItems> SumCalculatorItems(CalculatorItems items)
        {
            var calcItems = _services.SumCalculatorItems(items);

            if(calcItems == null)
            {
                return NotFound();
            }

            return calcItems;
        }

        [HttpGet]
        [Route("MultiplyCalculatorItems")]
        public ActionResult<CalculatorItems> MultiplyCalculatorItems(CalculatorItems items)
        {
            var calcItems = _services.MultiplyCalculatorItems(items);

            if (calcItems == null)
            {
                return NotFound();
            }

            return calcItems;
        }

        [HttpGet]
        [Route("DivideCalculatorItems")]
        public ActionResult<CalculatorItems> DivideCalculatorItems(CalculatorItems items)
        {
            var calcItems = _services.DivideCalculatorItems(items);

            if (calcItems == null)
            {
                return NotFound();
            }

            return calcItems;
        }

        [HttpGet]
        [Route("PowerCalculatorItems")]
        public ActionResult<CalculatorItems> PowerCalculatorItems(CalculatorItems items)
        {
            var calcItems = _services.PowerCalculatorItems(items);

            if (calcItems == null)
            {
                return NotFound();
            }

            return calcItems;
        }

        [HttpGet]
        [Route("SquareRootCalculatorItems")]
        public ActionResult<CalculatorItems> SquareRootCalculatorItems(CalculatorItems items)
        {
            var calcItems = _services.SquareRootCalculatorItems(items);

            if (calcItems == null)
            {
                return NotFound();
            }

            return calcItems;
        }
    }
}