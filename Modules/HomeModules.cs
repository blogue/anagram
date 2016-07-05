using AnagramChecker.Objects;
using Nancy;
using System.Collections.Generic;

namespace AnagramChecker{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
