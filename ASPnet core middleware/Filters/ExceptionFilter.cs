
using Microsoft.AspNetCore.Mvc.Filters;

public class ExceptionFilter:Attribute,IExceptionFilter
    {
    public void OnException(ExceptionContext context)
    {
        string file = "Exception_Filter.txt";
        using(StreamWriter sw = new StreamWriter(file, true))
        {
            sw.WriteLineAsync("apply Exception_Filter");
        }
    }
}


