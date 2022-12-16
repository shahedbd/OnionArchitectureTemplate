using Core.Entities.Models;
using Core.Repository.Data;
using Core.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly ICRUDService<Branch> _ICRUDService;
		private readonly ILogger<HomeController> _logger;

        public BranchController(ICRUDService<Branch> iCRUDService, ILogger<HomeController> logger)
        {
			_ICRUDService = iCRUDService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = _ICRUDService.GetAll().ToList();
            if (result.Count == 0)
            {
                InitBranchData();
            }
            return View(result);
        }

        public void InitBranchData()
        {
            SeedData _SeedData = new();
            var _GetCategoriesList = _SeedData.GetBranchList();
            foreach (var item in _GetCategoriesList)
            {
                item.CreatedDate = DateTime.Now;
                item.ModifiedDate = DateTime.Now;
                item.CreatedBy = "Admin";
                item.ModifiedBy = "Admin";
				_ICRUDService.Insert(item);
            }
        }
    }
}