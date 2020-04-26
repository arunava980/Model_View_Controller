using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public string  Index()
        {
            string result = @"<form>
                    <table>
                    <tr><td></td><td></td></tr>
                    </table></form>";
            return result;
        }
    }
}