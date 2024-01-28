using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;
using Solid.Core.DTOs;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductsService _ProductsService;
        private readonly IMapper _mapper;
        public ProductController(IProductsService availableProductsService)
        {
            _ProductsService = availableProductsService;
        }
        //public static readonly List<AviableProduct> _list = new List<AviableProduct>();
        //public static int i = 0;

        // GET: api/<ShoopingListController>
        [HttpGet]
        public ActionResult<Products> Get()
        {
            return Ok(_ProductsService.GetAll());
        }

        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult<Products> Get(int id)
        {
            return Ok(_mapper.Map<DTOProduct>(_ProductsService.GetById(id)));
            //return Ok(_ProductsService.GetById(id));
        }
        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] Products value)
        {
            _ProductsService.Update(value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public void  Put(int id, [FromBody] Products value)
        {
            _ProductsService.Put(id, value);
        }

        // DELETE api/<ShoopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _ProductsService.Delete(id);
            return NoContent();

        }
    }
}
