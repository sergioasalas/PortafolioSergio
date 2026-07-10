using Microsoft.AspNetCore.Mvc;
using PortafolioSergio.Models;
using PortafolioSergio.ViewModels;

namespace PortafolioSergio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Technologies =
            [
                "C#", ".NET 10", "ASP.NET Core MVC", "Entity Framework Core",
                "SQL Server", "ASP.NET Identity", "SignalR", "JavaScript",
                "HTML5", "CSS3", "Bootstrap", "Git y GitHub"
            ],
            Projects =
            [
                new ProjectItem
                {
                    Title = "Sistema web para salón de belleza",
                    Description = "Aplicación web desarrollada para un cliente, orientada a la gestión de servicios, citas, usuarios y administración del negocio. La identidad comercial del cliente se mantiene confidencial.",
                    ImageUrl = "/img/software-development.png",
                    Technologies = ["ASP.NET Core MVC", "Entity Framework Core", "SQL Server", "Identity"],
                    Status = "2026 · En desarrollo"
                },
                new ProjectItem
                {
                    Title = "Perfumteq",
                    Description = "Plataforma de comercio electrónico desarrollada durante la etapa productiva del SENA, con catálogo, autenticación, carrito de compras, pedidos y pasarelas de pago.",
                    ImageUrl = "/img/code-laptop.jpg",
                    Technologies = ["C#", "ASP.NET Core", "SQL Server", "PayU", "PayPal"],
                    Status = "Proyecto académico"
                },
                new ProjectItem
                {
                    Title = "Generador de contraseñas y QR",
                    Description = "Herramienta web para crear contraseñas seguras y códigos QR desde una interfaz sencilla, rápida y adaptable a dispositivos móviles.",
                    ImageUrl = "/img/contact-illustration.png",
                    Technologies = ["HTML5", "CSS3", "JavaScript"],
                    RepositoryUrl = "https://github.com/sergioasalas/Generador-QR-y-Contrase-as",
                    DemoUrl = "https://sergioasalas.github.io/Generador-QR-y-Contrase-as/",
                    Status = "Disponible"
                },
                new ProjectItem
                {
                    Title = "Reservaciones de hotel",
                    Description = "Aplicación académica para consultar habitaciones y gestionar reservaciones, enfocada en lógica de programación e interfaces web.",
                    ImageUrl = "/img/training.png",
                    Technologies = ["HTML5", "CSS3", "JavaScript"],
                    RepositoryUrl = "https://github.com/sergioasalas/Reservaciones-Hotel",
                    DemoUrl = "https://sergioasalas.github.io/Reservaciones-Hotel/",
                    Status = "Disponible"
                },
                new ProjectItem
                {
                    Title = "Mini videojuegos SENA",
                    Description = "Colección de proyectos académicos desarrollados para fortalecer lógica de programación, diseño de interfaces y trabajo colaborativo.",
                    ImageUrl = "/img/software-development.png",
                    Technologies = ["Lógica de programación", "POO", "Trabajo en equipo"],
                    Status = "Proyecto académico"
                }
            ]
        };

        return View(model);
    }
}
