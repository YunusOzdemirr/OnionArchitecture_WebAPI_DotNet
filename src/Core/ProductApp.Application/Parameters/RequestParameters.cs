namespace ProductApp.Application.Parameters;

public class RequestParameters
{
    public RequestParameters(int pageSize, int pageNumber)
    {
        PageSize = pageSize;
        PageNumber = pageNumber;
    }

    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}