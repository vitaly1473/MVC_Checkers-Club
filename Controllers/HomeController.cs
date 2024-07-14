// файл /Controllers/HomeController.cs
// контроллер отвечает за обработку HTTP-запросов и возвращение соответствующих ответов

using Microsoft.AspNetCore.Mvc;
using MVC_Checkers_Club.Models;

namespace MVC_Checkers_Club.Controllers
{
	public class HomeController : Controller
	{
        List<Picture> pictures = new List<Picture> //  создаём список объектов Picture
        {
            new Picture("d100_.png", "100 клеточная доска"),
            new Picture("d64_.png", "64 клеточная доска"),
            new Picture("russkie_shashki.jpg", "64 клеточная доска с шашками")
        };
		// метод Index обрабатывает запросы к корневому URL (/Home/Index или просто /, если настроен по умолчанию)
		public IActionResult Index()
		{
			return View(); //возвращаем представление Index, расположенное в папке Views/ Home
		}
        public IActionResult About() 
        {
            return View();
        }
		public IActionResult Profile()
		{
			return View(pictures);
		}
	}
}
