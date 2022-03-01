using Api.Enum;

namespace Api.Models;
public class User : BaseModel
{
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Doc {get; set;}
    public Status Status {get; set;}
}