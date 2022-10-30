using middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();



app.MapControllerRoute(    
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");           // если вводим в строку запроса /Home ,то попадаем сюда

app.middlewareMethod();                                           // если вводим в строку запроса /webapplication , то попадаем сюда

app.Run();

///2.Cоздать пользовательский Middleware и добавить его в конвейер обработки запроса через расширяющий метод.
///Задача этого компонента выполнять запись в файл адрес, по которому пользователь обратился к приложению.
///
///3. Создать модель Worker c полями: Name, Age, DateOfBirth, Address.
///
///4.Создать контроллер, который будет принимать пользовательские запросы. 
///Например, контроллер будет возвращать в ответ пользователю представление с данными модели Worker.
///Создание экземпляра класса Worker произвольное, можно создавать в момент выполнения метода контроллера.
///5. Создать все пять типов фильтров и добавить в глобальную область. Методы фильтров должны выполнять запись в отдельный файл. Проанализировать когда и в какой последовательности вызываются методы фильтров.

