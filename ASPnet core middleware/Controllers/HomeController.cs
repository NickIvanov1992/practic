using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using middleware.Models;



//[AuthorizationFilter]
//[ResourceFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
 //   [ResultFilter]
 //   [IndexActionFilter]
 //   [ExceptionFilter]
        public ActionResult Index()
        {
            return View("..//Home/register_user");             //  Ссылка на форму HTML
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
    
        public IActionResult PushUsers(string Name, string Age, string DateOfBirth, string Adress)
        {
        List<Worker> users = new List<Worker>();
        Worker worker = new Worker(Name, Age, DateOfBirth, Adress);
        users.Add(worker);
        return View("ViewUser",users);                 // вывел список зарег. пользователя
        }
}
