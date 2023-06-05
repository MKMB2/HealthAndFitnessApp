using HealthAndFitnessApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndFitnessApp.Controllers
{
    public class PedometerController : Controller
    {
        private readonly DB_Context context;

        public IActionResult index()
        {
            return View();
        }

        public PedometerController(DB_Context context)
        {
            this.context = context;
        }

        
        public IActionResult Steps()
        {
            return View();
        }


        [HttpPost]
        public IActionResult StepsTotalCalories(Model1 model)
        {
            double TotalCaloriesBurend = model.Numper_Of_Steps * 0.04;
            model.Date = DateTime.Now;
            context.models.Add(model);
            context.SaveChanges();

            ViewBag.TotalCaloriesBurend = TotalCaloriesBurend;
            return View();
        }
    }
}
