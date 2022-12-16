using Core.Repository.Data;
using Core.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _ICategoriesService;
        public CategoriesController(ICategoriesService iCategoriesService)
        {
            _ICategoriesService = iCategoriesService;
        }
        public IActionResult Index()
        {
            var result = _ICategoriesService.GetAll().ToList();
            if (result.Count == 0)
            {
                InitCategoriesData();
            }
            return View(result);
        }


        public void InitCategoriesData()
        {
            SeedData _SeedData = new();
            var _GetCategoriesList = _SeedData.GetCategoriesList();
            foreach (var item in _GetCategoriesList)
            {
                item.CreatedDate = DateTime.Now;
                item.ModifiedDate = DateTime.Now;
                item.CreatedBy = "Admin";
                item.ModifiedBy = "Admin";
                _ICategoriesService.Insert(item);
            }
        }
    }
}
