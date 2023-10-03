using AutoMapper;
using BusinessLayer.abstracts;
using DtoLayer.Dtos.experienceDto;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class experienceApiController : ControllerBase
    {
        private readonly IExperienceService _experienceService;
        private readonly IMapper _mapper;
        public experienceApiController(IExperienceService experienceService , IMapper mapper)
        {
            _mapper = mapper;
            _experienceService = experienceService;
        }
        [HttpGet]
        public IActionResult listExperience()
        {
            var values = _experienceService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertExperience(experienceAddDto experienceAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values= _mapper.Map<experience>(experienceAddDto);
            _experienceService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteExperience(int id)
        {
            var value = _experienceService.getById(id);
            _experienceService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateExperience(experience p)
        {
            _experienceService.update(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdExperience(int id)
        {
            var values = _experienceService.getById(id);
            return Ok(values);
        }
    }
}
