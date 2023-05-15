using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Tracking.Data;
using Tracking.Models;

namespace Tracking.Pages.Issues
{
    public class NewModel : PageModel
    {
        private readonly IssueDbContext _context;
        public NewModel(IssueDbContext issueDbContext) => _context = issueDbContext;

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost() 
        {
            try
            {
                if (!ModelState.IsValid) return Page();

                Issue.CreatedOn = DateTime.Now;
                await _context.Issues.AddAsync(Issue);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
              
            }
           
            
            return RedirectToPage("../Index");
        }

        [BindProperty]
        public Issue Issue { get; set; }

    }
}
