using Api.Enum;
namespace Api.Models;
public class NewUserAccount
{
    public long NewUserAccountId  {get; set;}
    public string Name { get; set; }
    public string Mail {get; set;}
    public string Doc {get; set;}
    public Status Status {get; set;}
    public DateTime CreateDate {get; set;}
    public DateTime UpdateDate {get; set;}
}