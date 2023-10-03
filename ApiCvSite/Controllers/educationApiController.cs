using AutoMapper;
using BusinessLayer.abstracts;
using DtoLayer.Dtos.educationDto;
using DtoLayer.Dtos.experienceDto;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class educationApiController : ControllerBase
    {
        private readonly IEducationService _educationService;
        private readonly IMapper _mapper;
        public educationApiController(IEducationService educationService, IMapper mapper)
        {
            _mapper = mapper;
            _educationService = educationService;
        }

        [HttpGet]
        public IActionResult listEducation()
        {
            var values = _educationService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertEducation(educationAddDto p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<education>(p);
            _educationService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteEducation(int id)
        {
            var value = _educationService.getById(id);
            _educationService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateEducation(education p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<education>(p);
            _educationService.update(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdEducation(int id)
        {
            var values = _educationService.getById(id);
            return Ok(values);
        }
    }
}
