
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class ResourceFilter : Attribute, IResourceFilter
{
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        context.Result = new ContentResult
        {
            Content = nameof(ResourceFilter)
        };
        string file = "Resourse_Filter.txt";

        using (StreamWriter sw = new StreamWriter(file, true))
        {
            sw.WriteLineAsync("apply Resourse_Filter");
        }
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        
    }
}

