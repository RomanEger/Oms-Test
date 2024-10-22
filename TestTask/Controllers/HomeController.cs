using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using TestTask.Models;
using TestTask.Repository;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<ActionResult> Index()
        {
            return View(await _userRepository.GetUsersAsync());
        }

        [HttpGet]
        public async Task<ActionResult> ChangeUser(int id)
        {
            return View(await _userRepository.GetUserAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> ChangeUser(User user)
        {
            await _userRepository.UpdateUserAsync(user);
            return RedirectToAction("Index");
        }
    }
}