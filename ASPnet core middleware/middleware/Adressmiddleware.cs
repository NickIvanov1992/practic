using Newtonsoft.Json;
using middleware;
using Microsoft.AspNetCore.Http;



    public class Adressmiddleware
    {
        private readonly RequestDelegate _next;
        public Adressmiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke (HttpContext context)
        {
        string str = context.Request.Path.Value;

        if (str == "/webapplication")                         // если вводим запрос , то идет запись запроса в TXT файл
        {
            string path = "record_adress.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLineAsync($"https://localhost:7282{str}");
            }
            context.Response.WriteAsync($"https://localhost:7282{str}");

        }
        else if (str == "/Home" || str == "/Home/PushUsers")                            // если вводим Home или /Home/PushUsers то передаем запрос дальше
            await _next(context);                                                       // /Home/PushUsers вызывает HomeController
        else                                                // иначе ошибка 404
            context.Response.StatusCode = 404;
        
        
    }
    
}

