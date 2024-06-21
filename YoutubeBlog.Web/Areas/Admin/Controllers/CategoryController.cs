using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using YoutubeBlog.Entity.DTOs.Categories;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concrete;
using YoutubeBlog.Web.ResultMessages;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IValidator<Category> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public CategoryController(ICategoryService categoryService, IValidator<Category> validator, IMapper mapper,IToastNotification toast)
        {
            this.categoryService = categoryService;
            this.validator = validator;
            this.mapper = mapper;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toast.AddSuccessToastMessage(
                    Messages.Category.Add(categoryAddDto.Name),
                    new ToastrOptions { Title = "Başarılı!" }
                );
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toast.AddSuccessToastMessage(
                    Messages.Category.Add(categoryAddDto.Name),
                    new ToastrOptions { Title = "İşlem Başarılı!" }
                );
                return Json(Messages.Category.Add(categoryAddDto.Name));
            }
            else
            {
                toast.AddErrorToastMessage(
                    result.Errors.First().ErrorMessage,
                    new ToastrOptions { Title = "İşlem Başarısız!" }
                );
                return Json(result.Errors.First().ErrorMessage);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await categoryService.GetCategoryByGuid(categoryId);
            var map = mapper.Map<Category, CategoryUpdateDto>(category);

            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = mapper.Map<Category>(categoryUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
                toast.AddSuccessToastMessage(
                    Messages.Category.Add(name),
                    new ToastrOptions { Title = "Başarılı!" }
                );
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var title = await categoryService.SafeDeleteArticleAsync(categoryId);

            toast.AddSuccessToastMessage(
                    Messages.Category.Delete(title),
                    new ToastrOptions { Title = "İşlem başarılı" }
                );

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }
    }
}
