using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RebelIdentificator.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RebelIdentificator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RebelRetriveController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Rebel> GetAllRebels()
        {
            return RebelIdentification.GetAllRebel();
        }

        [HttpGet("GetAllRebelRecords")]
        public JsonResult GetAllRebelRecords()
        {
            return Json(RebelIdentification.GetAllRebel());
        }
    }
}
