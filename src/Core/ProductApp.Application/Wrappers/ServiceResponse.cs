namespace ProductApp.Application.Wrappers;

public class ServiceResponse<T>
{
    public ServiceResponse(T value)
    {
        Value = value;
    }

    public ServiceResponse()
    {
    }

    public T Value { get; set; }
}