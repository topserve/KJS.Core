using Api.Models;
using Api.Repositry.Request;

namespace Api.Mapping;
public class UserMapper
{
    public User Map(UserRequest userRequest)
    {
        return new User
        {
            Name = userRequest.Name,
            Doc = userRequest.Doc,
            Status = Enum.Status.Created,
            CreateDate = userRequest.CreateDate,
            UpdateDate = userRequest.CreateDate,
            CreateId = 1,
            UpdateId = 1
        };
    }
}