using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Services;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;


        public ProjectController(IUserService userService, IProjectService projectService)
        {
            _userService = userService;
            _projectService = projectService;
        }

        [HttpGet]
        [Route("{idUser}", Name = "UserId")]
        public async Task<ActionResult> GetUserWithId(int idUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _userService.Get(idUser));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("AllProject")]
        public async Task<ActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _projectService.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjectDTOCreate projectDtoCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _projectService.Post(projectDtoCreate);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("UserId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProjectDTOUpdate dtoUpdate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _projectService.Put(dtoUpdate);
                if (result == null)
                {
                    return BadRequest();
                }

                return Ok(result);

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _projectService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
