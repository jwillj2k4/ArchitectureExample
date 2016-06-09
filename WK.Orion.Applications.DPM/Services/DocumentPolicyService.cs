using WK.Orion.Applications.DPM.Interfaces;
using WK.Orion.Platform.Tasks.Interfaces;
using WK.Orion.Platform.UserManagement.Interfaces;

namespace WK.Orion.Applications.DPM.Services
{
    public class DocumentPolicyService : IDocumentPolicyService
    {
        private readonly ITaskService _taskService;
        private readonly IUserService _userService;

        public DocumentPolicyService(ITaskService taskService, IUserService userService)
        {
            _taskService = taskService;
            _userService = userService;
        }

        public void GetOne(long id)
        {
            var task = _taskService.GetOne(id);
            var user = _userService.GetOne(task.CreatedByUserId);

            //do something with documents
        }
    }
}