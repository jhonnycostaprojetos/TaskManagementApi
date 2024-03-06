using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaskManagement.Application.DTOs.Comment;
using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskProjectController : ControllerBase
    {
        private readonly ITaskProjectService _taskProjService;
        private readonly ICommentService _commentService;


        public TaskProjectController(ITaskProjectService taskProjService, ICommentService commentService)
        {
            _taskProjService = taskProjService;
            _commentService = commentService;
        }

        [HttpGet]
        [Route("{idProject}", Name = "ProjectId")]
        public async Task<IActionResult> GetProjectWithId(int idProject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var a = await _taskProjService.GetAll(idProject);
                return Ok(a);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaskProjectDTOCreate taskprojectDtoCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _taskProjService.Post(taskprojectDtoCreate);

                if (result != null)
                {
                    return Ok(result);
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
        public async Task<ActionResult> Put([FromBody] TaskProjectDTOUpdate dtoUpdate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _taskProjService.Put(dtoUpdate);
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
                return Ok(await _taskProjService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost("Comment")]
        public async Task<IActionResult> PostComment([FromBody] CommentDTOCreate commentDtoCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _commentService.Post(commentDtoCreate);

                if (result != null)
                {
                    return Ok(result);
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
    }
}
