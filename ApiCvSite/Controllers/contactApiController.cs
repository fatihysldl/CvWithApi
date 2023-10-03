using AutoMapper;
using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contactApiController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public contactApiController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult listContact()
        {
            var values = _contactService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertContact(contact p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
             var values=_mapper.Map<contact>(p);   
            _contactService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteContact(int id)
        {
            var value = _contactService.getById(id);
            _contactService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateContact(contact p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<contact>(p);
            _contactService.update(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdContact(int id)
        {
            var values = _contactService.getById(id);
            return Ok(values);
        }
    }
}
