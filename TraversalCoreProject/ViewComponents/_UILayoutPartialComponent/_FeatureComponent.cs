using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _FeatureComponent : ViewComponent
    {
        FeatureMenager featureMenager = new FeatureMenager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureMenager.GetAll();
            return View(values);
        }
    }
}
