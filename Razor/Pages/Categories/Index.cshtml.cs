//We have named the module Categories becuase toherwise we had to add the complete using statements
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private List<Category> CategoriList {  get; set; }
        
        //public IndexModel(ApplicationDbContext db)
        //{
        //    _db = db;
        //}
        //public void OnGet()
        //{
        //    CategoriList = _db.Categories.ToList();
        //}
    }
}
