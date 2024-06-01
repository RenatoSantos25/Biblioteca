using Microsoft.AspNetCore.Mvc; 
using Biblioteca.Data;
using Biblioteca.Models;

namespace BibliotecaTeste.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDBContext _db;
        public EmprestimoController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
            return View();
        }
    }
}
