using System.Collections.Generic;
using System.Threading.Tasks;
using Module5HW1.Services.Abstractions;

namespace Module5HW1
{
    public class Starter
    {
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;
        public Starter(IUserService userService, IResourceService resourceService, IRegisterService registerService, ILoginService loginService)
        {
            _userService = userService;
            _resourceService = resourceService;
            _registerService = registerService;
            _loginService = loginService;
        }

        public void Run()
        {
            var list = new List<Task>();

            list.Add(Task.Run(async () => await _userService.GetListUsers()));
            list.Add(Task.Run(async () => await _userService.GetSingleUser()));
            list.Add(Task.Run(async () => await _userService.GetSingleUserNotFound()));
            list.Add(Task.Run(async () => await _userService.PostCreate()));
            list.Add(Task.Run(async () => await _userService.PutUpdate()));
            list.Add(Task.Run(async () => await _userService.PatchUpdate()));
            list.Add(Task.Run(async () => await _userService.Delete()));
            list.Add(Task.Run(async () => await _userService.GetDelayedResponse()));
            list.Add(Task.Run(async () => await _resourceService.GetListResources()));
            list.Add(Task.Run(async () => await _resourceService.GetSingleResource()));
            list.Add(Task.Run(async () => await _resourceService.GetSingleResourceNotFound()));
            list.Add(Task.Run(async () => await _registerService.PostRegisterSuccessful()));
            list.Add(Task.Run(async () => await _registerService.PostRegisterUnsuccessful()));
            list.Add(Task.Run(async () => await _loginService.PostLoginSuccessful()));
            list.Add(Task.Run(async () => await _loginService.PostLoginUnsuccessful()));

            Task.WhenAll(list).GetAwaiter().GetResult();
        }
    }
}
