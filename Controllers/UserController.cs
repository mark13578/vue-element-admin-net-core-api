using Microsoft.AspNetCore.Mvc;

namespace JMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            // Placeholder for logic to get a user by ID
            return Ok(new { userId = id, name = "John Doe", role = "Admin" });
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserCreateRequest request)
        {
            // Placeholder for logic to create a new user
            return Ok(new { message = "User created successfully", userName = request.Name });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserUpdateRequest request)
        {
            // Placeholder for logic to update a user
            return Ok(new { message = "User updated successfully", userId = id });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // Placeholder for logic to delete a user
            return Ok(new { message = "User deleted successfully", userId = id });
        }
    }

    // DTO classes for user requests
    public class UserCreateRequest
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class UserUpdateRequest
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
