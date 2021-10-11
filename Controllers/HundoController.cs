using Microsoft.AspNetCore.Mvc;
using MVCHundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHundo.Controllers
{
    public class HundoController : Controller
    {
        [HttpPost]
        public IActionResult Index(HundoNumbers nums)
        {
            //generate a list of functions with results properties
            List<string> numItems = new List<string>();

            for (int i = nums.StartValue; i <= nums.EndValue; i++)
            {
                numItems.Add(i.ToString());
            }

            nums.Results = numItems;

            return View(nums);
        }

        public IActionResult Index()
        {
            HundoNumbers nums = new HundoNumbers();

            nums.StartValue = 1;
            nums.EndValue = 100;

            return View(nums);
        }
    }
}