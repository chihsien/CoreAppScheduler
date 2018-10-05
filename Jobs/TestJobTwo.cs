using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;

namespace HostedService.Quartz.Jobs
{
    public class TestJobTwo : IJob
    {
        private readonly ILogger _logger;

        public TestJobTwo(ILogger<TestJobTwo> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation(string.Format("TestJobTwo - [{0:yyyy-MM-dd hh:mm:ss:ffffff}]任务执行！", DateTime.Now));
            return Task.CompletedTask;
        }
    }
}