using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            pieRepository = _pieRepository;
            categoryRepository = _categoryRepository;
        }

        public ViewResult List()
        {
            return View(_pieRepository.Pies);
        }
    }
}