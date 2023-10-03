using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class headerApiController : ControllerBase
    {
        private readonly IHeaderService _headerService;

        public headerApiController(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        [HttpGet]
        public IActionResult listHeader()
        {
            var values = _headerService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertHeader(header p)
        {
            _headerService.insert(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteHeader(int id)
        {
            var value = _headerService.getById(id);
            _headerService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateHeader(header p)
        {
            _headerService.update(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdHeader(int id)
        {
            var values = _headerService.getById(id);
            return Ok(values);
        }
    }
}
