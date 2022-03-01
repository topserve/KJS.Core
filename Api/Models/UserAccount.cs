using Api.Enum;

namespace Api.Models;
public class UserAccount : BaseModel
{

    public long UserAccountId {get; set;}
    public Status Status {get; set;}

}