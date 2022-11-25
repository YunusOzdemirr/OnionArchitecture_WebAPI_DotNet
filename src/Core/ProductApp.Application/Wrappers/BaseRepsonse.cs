namespace ProductApp.Application.Wrappers;

public class BaseRepsonse
{
    public int Id { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
}