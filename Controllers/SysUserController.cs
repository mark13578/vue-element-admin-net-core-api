//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System.Net.Mime;

//namespace JMWebAPI.Controllers
//{
//    public class SysUserController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JMWebAPI.Common.Result;
using JMWebAPI.Models;
using JMWebAPI.Models.Form;
using JMWebAPI.Models.Query;
using JMWebAPI.Models.VO;
using JMWebAPI.Services;
using System.IO;
using System.Net.Mime;
using System.Text.Json;


namespace JMWebAPI.Controllers
{
    /// <summary>
    /// User Management Controller
    /// </summary>
    [ApiController]
    [Route("api/v1/users")]
    public class SysUserController : ControllerBase
    {
        private readonly SysUserService _userService;
        private readonly ILogger<SysUserController> _logger;

        public SysUserController(SysUserService userService, ILogger<SysUserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpGet("page")]
        [Authorize(Policy = "UserList")]
        public IActionResult ListPagedUsers([FromQuery] UserPageQuery queryParams)
        {
            var result = _userService.ListPagedUsers(queryParams);
            return Ok(new PageResult<UserPageVO>(result));
        }

        [HttpPost]
        [Authorize(Policy = "AddUser")]
        public IActionResult SaveUser([FromBody] UserForm userForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _userService.SaveUser(userForm);
            return result ? Ok() : StatusCode(500, "Failed to save user.");
        }

        [HttpGet("{userId}/form")]
        public IActionResult GetUserForm(long userId)
        {
            var userForm = _userService.GetUserFormData(userId);
            return Ok(userForm);
        }

        [HttpPut("{userId}")]
        [Authorize(Policy = "EditUser")]
        public IActionResult UpdateUser(long userId, [FromBody] UserForm userForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _userService.UpdateUser(userId, userForm);
            return result ? Ok() : StatusCode(500, "Failed to update user.");
        }

        [HttpDelete("{ids}")]
        [Authorize(Policy = "DeleteUser")]
        public IActionResult DeleteUsers(string ids)
        {
            var result = _userService.DeleteUsers(ids);
            return result ? Ok() : StatusCode(500, "Failed to delete users.");
        }

        [HttpPatch("{userId}/password")]
        [Authorize(Policy = "ResetPassword")]
        public IActionResult UpdatePassword(long userId, [FromQuery] string password)
        {
            var result = _userService.UpdatePassword(userId, password);
            return result ? Ok() : StatusCode(500, "Failed to update password.");
        }

        [HttpPatch("{userId}/status")]
        public IActionResult UpdateUserStatus(long userId, [FromQuery] int status)
        {
            var result = _userService.UpdateUserStatus(userId, status);
            return result ? Ok() : StatusCode(500, "Failed to update user status.");
        }

        [HttpGet("me")]
        public IActionResult GetCurrentUserInfo()
        {
            var userInfoVO = _userService.GetCurrentUserInfo();
            return Ok(userInfoVO);
        }

        [HttpGet("template")]
        public IActionResult DownloadTemplate()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Templates", "UserImportTemplate.xlsx");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, MediaTypeNames.Application.Octet, "UserImportTemplate.xlsx");
        }

        [HttpPost("import")]
        public IActionResult ImportUsers([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var result = _userService.ImportUsers(file.OpenReadStream());
            return Ok(result);
        }

        [HttpGet("export")]
        public IActionResult ExportUsers([FromQuery] UserPageQuery queryParams)
        {
            var exportUsers = _userService.ListExportUsers(queryParams);
            var memoryStream = _userService.ExportUsersToExcel(exportUsers);
            return File(memoryStream.ToArray(), MediaTypeNames.Application.Octet, "UserList.xlsx");
        }
    }
}
