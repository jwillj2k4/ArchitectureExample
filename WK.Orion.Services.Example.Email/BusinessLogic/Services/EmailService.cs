using WK.Orion.Platform.Examples.Components.Tasks.Interfaces;
using WK.Orion.Services.Example.Email.BusinessLogic.Interfaces;

namespace WK.Orion.Services.Example.Email.BusinessLogic.Services
{
    /// <summary>   An udf service. </summary>
    public class EmailService : IEmailService
    {
        private readonly ITaskService _taskService;

        public EmailService(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void Run()
        {
            _taskService.GetOne(3);
        }
    }
}