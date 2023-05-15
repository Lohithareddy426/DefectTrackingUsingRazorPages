using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLitePCL;
using Tracking.Data;
using Tracking.Models;

namespace Tracking.Pages.Issues
{
    public class DetailsModel : PageModel
    {
        private readonly IssueDbContext _dbContext;
        public DetailsModel(IssueDbContext issueDbContext) {
            _dbContext = issueDbContext;
        }

        public Issue? Issue { get; private set; }

        public void OnGet(int id)
        {
            Issue = _dbContext.Issues.Find(id);
        }

        public void OnGetResolve(int id)
        {
            var issueToResolve = _dbContext.Issues.SingleOrDefault(x => x.Id == id);
            if (issueToResolve == null) return;

            issueToResolve.CompletedOn = DateTime.Now;
            _dbContext.Update(issueToResolve);
            _dbContext.SaveChanges();
        }
    }
}
