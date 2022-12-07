using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoLibrary;
namespace RazorPagesMiniProject.Pages;

public class People : PageModel
{
    [BindProperty] 
    
    public PersonModel person { get; set; }
    
    public void OnGet()
    
    {
        
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid == false)
        {
            return Page();
        }

        return RedirectToPage("./index");
    }
}