namespace CamaraBrazopolisAPI.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate NEXT;

    public ExceptionMiddleware(RequestDelegate next)
    {
        NEXT = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await NEXT(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;

        var response = new
        {
            message = ex.Message,
            details = ex.StackTrace
        };

        return context.Response.WriteAsJsonAsync(response);
    }
}
