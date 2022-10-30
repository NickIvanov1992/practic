using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using middleware;
using Microsoft.AspNetCore.Http;
public class IndexActionFilter : Attribute, IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        context.HttpContext.Response.Cookies.Append("Append_cookie", "Cookie_value");
        string file = "Action_Filter.txt";

        using (StreamWriter sw = new StreamWriter(file, true))
        {
            sw.WriteLineAsync("apply Actionfilter");
        }
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
       
    }
}
