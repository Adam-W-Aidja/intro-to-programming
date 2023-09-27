using Microsoft.AspNetCore.Mvc;
namespace TodosApi.Controllers;

public class TodoListController : ControllerBase
{
    // GET /todo-list
    [HttpGet("/todo-list")]
    public async Task<ActionResult> GetTodoList()
    {
        return Ok();
    }
}