namespace Api.Repositry.Request;

public class NewUserAccountRequest
{
    public string Name { get; set; }
    public string Mail {get; set;}
    public string Doc {get; set;}
    public DateTime CreateDate {get; set;}
}