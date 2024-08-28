using Microsoft.AspNetCore.Mvc;

namespace G5.NetITIMVCDay02.Controllers
{
    public class TestController : Controller
    {
        // Action 
        // => Can't be private
        // => Can't be static
        // => Can't be overload


        // Action
        // Controller/Action
        // Test/ShowHello
        public string ShowHello()
        {
            return "Hello from Test Controller";
        }

        public ContentResult ShowHello2()
        {
            // DeclareObj
            ContentResult contentResult = new ContentResult();
            // Set Return
            contentResult.Content = "Hello from test controller Show Hello 2";
            // return
            return contentResult;
        }

        public ViewResult ShowHello3()
        {
            // DeclareObj
            ViewResult viewResult = new ViewResult();
            // Set Return
            viewResult.ViewName = "Show";
            // return
            return viewResult;
        }

        public ViewResult ShowHello4()
        {
            return View(); // return view with the same name with Action
        }

        public IActionResult ShowHello5()
        {
            return View(); // return view with the same name with Action
        }

        // Type of Return of Action
        // 1- Content "String"    => ContentResult
        // 2- View "HTML"         => ViewResult
        // 3- JavaScript          => JavascriptResult
        // 4- Json                => JsonResult
        // 5- NotFound            => NotFoundResult
        // 6- File                => FileResult
    }
}
