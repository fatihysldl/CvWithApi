using AutoMapper;
using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class aboutApiController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public aboutApiController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult listAbout()
        {
            var values = _aboutService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertAbout(about p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  
            }
            var values=_mapper.Map<about>(p);
            _aboutService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAbout(int id)
        {
            var value= _aboutService.getById(id);
            _aboutService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateAbout(about p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<about>(p);
            _aboutService.update(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdAbout(int id) 
        { 
            var values=_aboutService.getById(id);
            return Ok(values);
        }
    }
}
