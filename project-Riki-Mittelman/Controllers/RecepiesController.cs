using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;
using Solid.Core.DTOs;
using Solid.Core.Service;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RecepiesController : ControllerBase
    {
        private readonly IRecepiesService _RecepiesService;
        private readonly IMapper _mapper;
        public RecepiesController(IRecepiesService RecepiesService, IMapper mapper)
        {
            _RecepiesService = RecepiesService;
            _mapper = mapper;
        }

        // GET: api/<ShoopingListController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_RecepiesService.GetAll());
        }

        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult Get(int id)
        {
            return Ok( _mapper.Map<DTORecepies>(_RecepiesService.GetById(id)));
        }
        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] Recepies value)
        {
            _RecepiesService.Update( value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recepies value)
        {    
            _RecepiesService.Put(id, value);
        }

        // DELETE api/<ShoopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _RecepiesService.Delete(id);
            return NoContent();


        }
    }
}
