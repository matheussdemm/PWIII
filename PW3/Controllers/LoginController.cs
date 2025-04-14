using Microsoft.AspNetCore.Mvc;
using PW3.Models;

namespace PW3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Logar(LoginModel dados)
        {
            LoginModel model = new LoginModel();
            model.Login = "matheussdem65@gmail.com";
            model.Senha = "433221";
            return View(model); //Lembra de colocar model para fazer conecao com o LoginModel
        }
    }
}
