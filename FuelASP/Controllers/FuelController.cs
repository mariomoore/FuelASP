using FuelASP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelASP.Controllers
{
    public class FuelController : Controller
    {
        // GET: Fuel
        public ActionResult Index()
        {
            return View("FuelCalc");
        }

        [HttpGet]
        public ActionResult FuelCalc()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FuelCalc(FuelViewModel fuelViewModel)
        {
            if (ModelState.IsValid)
            {
                if (fuelViewModel.Distance != (double)0)
                {
                    fuelViewModel.AverageFuelBurn = fuelViewModel.FuelBurned / fuelViewModel.Distance;
                    return View(fuelViewModel);
                }
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}