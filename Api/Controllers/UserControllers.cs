using Microsoft.AspNetCore.Mvc;
using Api.Repositry.Interface;
using Api.Repositry.Request;
using Api.Mapping;
using Api.Models;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly UserMapper _mapper;
    private readonly IUserRepository _repository;
    public  UserController(IUserRepository repository)
    {
        _repository = repository;
        _mapper = new UserMapper();
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserRequest userRequest)
    {
        User user = _mapper.Map(userRequest);
        _repository.InsertUser(user);
        return await _repository.SaveChangesAsync()
                ? Ok("ok")
                : BadRequest("Erro");
    }
}
