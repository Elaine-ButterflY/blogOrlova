using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogOrlova.Controllers
{
    /// <summary>
    /// Контроллер приложения blogOrlova. В нём хранятся методы, отображающие данные блога.
    /// </summary>
    public class BlogController : Controller
    {
        /// <summary>
        /// Отображение данных страницы РАСХИТИТЕЛЬНИЦА ГРОБНИЦ
        /// </summary>
        /// <returns>Возвращает представление, страницу на HTML-коде, которая содержит информацию о первой игре серии.</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Отображение данных страницы ХРОНИКИ
        /// </summary>
        /// <returns>Возвращает представление, страницу на HTML-коде, которая содержит информацию о пятой игре серии.</returns>
        public IActionResult Index1()
        {
            return View();
        }
        /// <summary>
        /// Отображение данных страницы 2013
        /// </summary>
        /// <returns>Возвращает представление, страницу на HTML-коде, которая содержит информацию о девятой игре серии.</returns>
        public IActionResult Index2()
        {
            return View();
        }
    }
}
