namespace ProductApp.Application.Wrappers;

public class PageResponse<T> : ServiceResponse<T>
{
    public PageResponse(T value) : base(value)
    {
    }

    public PageResponse()
    {
        PageNumber = 1;
        PageSize = 10;
    }

    public PageResponse(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }

    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}