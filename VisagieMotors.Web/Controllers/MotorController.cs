using System.Web.Mvc;
using VisagieMotors.Repository;
using VisagieMotors.Web.Models;

namespace VisagieMotors.Web.Controllers
{
    public class MotorController : Controller
    {
        // GET: Motor
        public ActionResult Index()
        {
            var repo = new MotorRepository();

            var model = new MotorsModel();

            model.Motors = repo.GetAll();

            return View(model);
        }
    }
}