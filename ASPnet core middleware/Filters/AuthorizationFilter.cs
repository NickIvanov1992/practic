using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;

public class AuthorizationFilter : Attribute,IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        string file = "Authorization_Filter.txt";

        using (StreamWriter sw = new StreamWriter(file, true))
        {
            sw.WriteLineAsync("apply Authorization_Filter");
        }
    }
}

