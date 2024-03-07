using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        [Route("{userIdManager}", Name = "Report")]
        public async Task<IActionResult> GenerateReport(int userIdManager)
        {
            return Ok(await _reportService.Get(userIdManager));

        }

        [HttpGet("ViewLogs")]
        public async Task<IActionResult> ViewLogs()
        {
            return Ok(await _reportService.GetAll());

        }
    }
}
