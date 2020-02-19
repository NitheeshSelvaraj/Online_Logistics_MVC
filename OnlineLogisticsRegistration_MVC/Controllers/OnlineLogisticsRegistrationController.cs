using Repository;
using System.Web.Mvc;
using UserEntity;

namespace OnlineLogisticsRegistration_MVC.Controllers
{
    public class OnlineLogisticsRegistrationController : Controller
    {
        UserRepository userRepository = new UserRepository();
        // GET: OnlineLogisticsRegistration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            if(ModelState.IsValid)
            {
                User user = new User();
                UpdateModel<User>(user);
                userRepository.Add(user);
                
            }
            return View();

        }
        public ActionResult Login()
        {
            
            return View();
        }
    }
}