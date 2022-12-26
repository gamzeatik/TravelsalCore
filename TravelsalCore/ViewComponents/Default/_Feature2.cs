using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCore.ViewComponents.Default
{
    public class _Feature2:ViewComponent
    {
        Feature2Manager featureManager = new Feature2Manager(new EfFeature2Dal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
