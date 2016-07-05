using AnagramChecker.Objects;
using Nancy;
using System.Collections.Generic;
using System;

namespace AnagramChecker{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        char[] delim = {' ',','};
        List<string> testList = new List<string> {};
        string userInput = Request.Form["user-string"];
        var inputAnagramArray = userInput.Split(delim);
        foreach(string word in inputAnagramArray)
        {
          testList.Add(word);
        }
        List<string> userList  = Anagram.CheckForAnagram(Request.Form["user-word"], testList);
        return View["result.cshtml", userList];
      };
    }
  }
}
