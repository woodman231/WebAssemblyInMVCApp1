using Microsoft.AspNetCore.Mvc;
using WebAssemblyInMVCApp1.Models;

namespace WebAssemblyInMVCApp1.ViewComponents
{
    public class ItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Item itemDetails)
        {
            return View(itemDetails);
        }
    }
}
