using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogOrlova.Models;

namespace blogOrlova.Controllers
{
    /// <summary>
    /// Контроллер приложения blogOrlova. В нём описывается работа с веб-сервером.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="logger">Через него посредством механизма dependency injection передается сервис ILogger, используемый для логгирования.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Отображение данных страницы ЛАРА КРОФТ
        /// </summary>
        /// <returns>Возвращает представление, главную страницу</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Отображение данных страницы Конфиденциальность
        /// </summary>
        /// <returns>Возвращает представление, страницу политики конфиденциальности</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
