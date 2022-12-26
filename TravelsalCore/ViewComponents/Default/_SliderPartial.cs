using Microsoft.AspNetCore.Mvc;

namespace TravelsalCore.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
