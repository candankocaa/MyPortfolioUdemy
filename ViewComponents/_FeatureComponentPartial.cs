using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent
    {
        MyPortfolioContext portfoliocontext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        { var values=portfoliocontext.Features.ToList();
            return View(values);
        }
    }
}
