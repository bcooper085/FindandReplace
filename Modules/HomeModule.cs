using Nancy;
using System;
using System.Collections.Generic;
using FindReplace.Objects;

namespace FindReplaceModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/replace_form"] = _ => {
        FindsReplaces obj = new FindsReplaces();
        string output = obj.FindsAndReplaces(Request.Form["inputString"], Request.Form["targetWord"], Request.Form["replaceWord"]);
        return View["results.cshtml", output];
      };
    }
  }
}
