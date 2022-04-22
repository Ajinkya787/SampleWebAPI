using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Services;
using SampleWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _prodservice;
        private object prod;

        public ProductController(IProductServices prodservice)
        {
            _prodservice = prodservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product/GetProducts")]

        public IActionResult GetProduct(Product prod)
        {
            return new ObjectResult(_prodservice.AddProduct(prod));
        }
        [HttpGet]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_prodservice.DeleteProduct(id));
        }
    }
}
