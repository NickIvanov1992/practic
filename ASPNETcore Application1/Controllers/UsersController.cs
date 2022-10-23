using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Diagnostics;
using Newtonsoft.Json;




    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View("..//Users/register");             //  Ссылка на форму HTML
        }

        public ActionResult Create()
        {
            return View();
        }
    public IActionResult AllUsers()             //  Вывести список всех зарегистрированных
    {
        List<UserInfo> users = new List<UserInfo>();
        string[] Array = System.IO.File.ReadAllLines("userinfo1.json");  //  Читать из сериализованного файла

        foreach (var s in Array)
        {
           users.Add(JsonConvert.DeserializeObject<UserInfo>(s));
        }
        return View("AllUsers", users);
    }
    [HttpPost]
        public IActionResult PushUsers( string firstname, string secondname, string middlename, string dateofbirth, string gender, string info)
        {
            UserInfo userinfo = new UserInfo(firstname, secondname, middlename, dateofbirth, gender, info);
            using (StreamWriter streamwriter = new StreamWriter("userinfo1.json", true))        // StreamWriter для добавления данных в текущий файл
            {
                string str = JsonConvert.SerializeObject(userinfo);
                streamwriter.WriteLine(str);
            }
            return View("register");
     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    }

