using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private IRepository<LogTaskProject> _repositoryLog;
        public ReportService(IReportRepository reportRepository, IRepository<LogTaskProject> repositoryLog)
        {
            _reportRepository = reportRepository;
            _repositoryLog = repositoryLog;
        }
        public async Task<object> Get(int id)
        {
           return await _reportRepository.Get(id);
        }

        public async Task<IEnumerable<object>> GetAll()
        {
            return await _repositoryLog.SelectAsync();

        }
    }
}
