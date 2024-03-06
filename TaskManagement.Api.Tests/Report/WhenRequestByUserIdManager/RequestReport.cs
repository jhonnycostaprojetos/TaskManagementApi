using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Report.WhenRequestByUserIdManager
{
    public class RequestReport
    {
        private ReportController _reportController;

        [Fact(DisplayName = "ReportByUserIdManager")]

        public async Task Report_By_UserIdManager()
        {
            var serviceReportMock = new Mock<IReportService>();

            serviceReportMock.Setup(m => m.Get(It.IsAny<int>())).Returns(Task.FromResult((object)null));

            _reportController = new ReportController(serviceReportMock.Object);

            var result = await _reportController.GenerateReport(1);
            Assert.True(result is OkObjectResult);
        }
    }
}
