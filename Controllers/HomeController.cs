using Microsoft.AspNetCore.Mvc;
using Mission11_Hermansen.Models;
using Mission11_Hermansen.Models.ViewModels;
using SQLitePCL;
using System.Diagnostics;

namespace Mission11_Hermansen.Controllers
{
    
    public class HomeController : Controller
    {
        private IAmazonRepository _repo;
        public HomeController(IAmazonRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var blah = new ProjectsListViewModel
            {
                Books = _repo.Books
               .OrderBy(x => x.BookID)
               .Skip((pageNum - 1) * pageSize)
               .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItmes = _repo.Books.Count()
                }
            };
            return View(blah);
        }

    }
}
