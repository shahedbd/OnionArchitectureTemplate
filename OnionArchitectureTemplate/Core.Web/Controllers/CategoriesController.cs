using Core.Entities.Models;
using Core.Repository.Data;
using Core.Service.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			return View(result.OrderByDescending(x => x.Id));
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Categories entity)
		{
			if (ModelState.IsValid)
			{
				entity.CreatedDate = DateTime.Now;
				entity.ModifiedDate = DateTime.Now;
				entity.CreatedBy = "Admin";
				entity.ModifiedBy = "Admin";
				await _ICategoriesService.Insert(entity);
				return RedirectToAction(nameof(Index));
			}
			return View(entity);
		}
        public async Task<IActionResult> Delete(Int64 id)
        {
			var result = await _ICategoriesService.Get(id);
            return View(result);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            await _ICategoriesService.Delete(id);
            TempData["successAlert"] = "Categories Info Deleted Successfully. ID: " + id;
            return RedirectToAction(nameof(Index));
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
