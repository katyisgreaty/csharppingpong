using Nancy;
using System;
using System.Collections.Generic;
using PingPongApp.Objects;

namespace PingPongApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["PingPong.cshtml"];
      };

      Post["/output"] = _ => {
        PingPong numberList = new PingPong(Request.Form["ceiling-number"]);
        List<string> finalOutput = numberList.PrintArray();
        return View["output.cshtml", finalOutput];
      };
    }
  }
}
