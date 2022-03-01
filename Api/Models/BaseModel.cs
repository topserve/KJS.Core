using System.Security.Cryptography.X509Certificates;
namespace Api.Models;
public class BaseModel
{
    public DateTime CreateDate {get; set;}
    public DateTime UpdateDate { get; set; }
    public long CreateId { get; set; }
    public long UpdateId {get; set;}
}