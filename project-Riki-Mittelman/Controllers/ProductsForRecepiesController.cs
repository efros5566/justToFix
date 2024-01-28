using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;
using Solid.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsForRecepiesController : ControllerBase
    {
        private readonly IProductsForRecepiesService _ProductsForRecepiesService;
        public ProductsForRecepiesController(IProductsForRecepiesService ShopingListService)
        {
            _ProductsForRecepiesService = ShopingListService;
        }

        // GET: api/<ShoopingListController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_ProductsForRecepiesService.GetAll());
        }
        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult Get(int id)
        {
            return Ok(_ProductsForRecepiesService.GetById(id));
        }
        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] ProductsForRecepies value)
        {
            _ProductsForRecepiesService.Update( value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductsForRecepies value)
        {
            _ProductsForRecepiesService.Put(id, value);

        }

        // DELETE api/<ShoopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _ProductsForRecepiesService.Delete(id);
            return NoContent();


        }
    }
}
