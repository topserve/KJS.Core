using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Data;
using Api.Repositry.Interface;
using Api.Repositry.Request;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    public  UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody]User user)
    {
        _repository.InsertUser(user);
        return await _repository.SaveChangesAsync()
                ? Ok("susesso")
                : BadRequest("erro");
    }
    
    [HttpPost("[action]")]
    public IActionResult NewUserAccount(NewUserAccountRequest newUserAccountRequest)
    {
        return Ok();
    }
}
