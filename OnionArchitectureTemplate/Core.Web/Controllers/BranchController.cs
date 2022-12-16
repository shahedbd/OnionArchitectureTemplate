using Core.Repository.Data;
using Core.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchService _IBranchService;
        private readonly ILogger<HomeController> _logger;

        public BranchController(IBranchService iBranchService, ILogger<HomeController> logger)
        {
            _IBranchService = iBranchService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = _IBranchService.GetAll().ToList();
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
                _IBranchService.Insert(item);
            }
        }
    }
}