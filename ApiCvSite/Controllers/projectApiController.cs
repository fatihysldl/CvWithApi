using AutoMapper;
using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCvSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class projectApiController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public projectApiController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult listProject()
        {
            var values = _projectService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertProject(project p)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values=_mapper.Map<project>(p);
            _projectService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteProject(int id)
        {
            var value = _projectService.getById(id);
            _projectService.delete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateProject(project p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<project>(p);
            _projectService.update(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getByIdProject(int id)
        {
            var values = _projectService.getById(id);
            return Ok(values);
        }
    }
}
