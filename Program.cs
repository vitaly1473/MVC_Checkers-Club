/*ƒ«
Ќа основе списка экзаменнационных работат выбрать дл€ себ€ свой проект. ƒопустимо изменение контекста, напр. темы или правил сайта.
ƒл€ своего проекта опишите несколько простых страниц и навигацию между ними на основе минимального набора данных.
 */
// файл Programm.cs

// https://metanit.com/sharp/aspnetmvc/1.4.php

var builder = WebApplication.CreateBuilder(args);

// подключение сервисов MVC
// поддержка контроллеров с представлени€ми
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles(); // доступ к картинкам

// установка сопоставлени€ маршрутов с контроллерами
// установка маршрутов с контроллерами
/*  ћетод app.MapControllerRoute добавл€ет один маршрут с именем default и шаблоном "{controller=Home}/{action=Index}/{id?}". 
   ƒанный шаблон устанавливает трехсегментную структуру строки запроса: controller/action/id. 
   “о есть в начале идет название контроллера, затем название действи€, и далее может идти необ€зательный параметр id.
 */
app.MapControllerRoute(
	name: "default",
	//pattern: "{controller=main}/{action=index}"
	pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
