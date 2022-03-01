using Api.Enum;
namespace Api.Models;

public class Account : BaseModel
{
    public long AccountId { get; set; }
    public string Name { get; set; }
    public string Doc {get; set;}
    public Status Status {get; set;}
    public ICollection<UserAccount> UserAccountId {get; set;}
}