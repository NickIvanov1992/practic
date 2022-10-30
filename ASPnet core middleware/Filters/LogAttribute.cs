using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;

public class LogAttribute :ActionFilterAttribute
    {
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);
    }
}
