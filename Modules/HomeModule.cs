using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;


namespace WordCounter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/result"] = _ => {
                string sentence = Request.Form["sentence"];
                string wordSelect = Request.Form["word"];
                RepeatCounter newCounter = new RepeatCounter(sentence, wordSelect);
                return View["results.cshtml", newCounter];
            };
        }
    }
}
