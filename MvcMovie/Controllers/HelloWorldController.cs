using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;



    // GET: /HelloWorld/Welcome/ 
    /*public string Welcome()
    {
        return "This is Srujana's Welcome page...";
    }*/
    /*public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }*/
    /*public string Welcome(string name, int ID = 4)
      {
          return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
      }*/

}